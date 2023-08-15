///////////////////////////////////////////////////////////////////////////////
//
// (C) 2023 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.IO;
using Wisej.Hybrid.Features.Panels;
using Wisej.Hybrid.Shared.AppActions;
using Wisej.Hybrid.Shared.Sensor;
using Wisej.Hybrid.Shared.StatusBar;
using Wisej.Web;
using Toast = Wisej.Web.Toast;

namespace Wisej.Hybrid.Features
{
	public partial class MainPage : Page
	{
		private TestBase currentView;

		private TestBase integrations = new Integrations();

		public MainPage()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			if (Application.Browser.Device == "Desktop")
				this.panelContainer.Padding = new Padding(16, 16, 16, 16);

			// default view.
			SwitchView(this.integrations);

			if (Device.Valid)
				InitializeNative();

			LoadTheme(Application.Browser.IsDarkMode);
		}

		private void InitializeNative()
		{
			//Device.Sensors.Start(SensorType.Shake);
			//Device.Sensors.ReadingChanged += Sensors_ReadingChanged;

			Device.AppActions.ItemActivated += AppActions_ItemActivated;

			// show version info.
			var versioning = Device.Info.Versioning;
			if (versioning.IsFirstLaunchEver)
				new Toast($"Welcome to Wisej.NET Hybrid {versioning.CurrentVersion}").Show();
			else
				new Toast($"Welcome back to Wisej.NET Hybrid {versioning.CurrentVersion}").Show();

			SetNativeColors();
		}

		private void SetNativeColors()
		{
			var window = ColorTranslator.FromHtml(Application.Theme.Colors.window);

			Device.StatusBar.BackColor = window;
			Device.BottomBar.BackColor = window;
			Device.Background.BackColor = window;

			if (Application.Theme.Name == "Bootstrap-4")
				Device.StatusBar.TextColor = StatusBarTextColor.Black;
			else
				Device.StatusBar.TextColor = StatusBarTextColor.White;
		}

		private void AppActions_ItemActivated(object sender, AppAction e)
		{
			AlertBox.Show($"Selected Shortcut: {e.Title}");
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			if (e.Sensor == SensorType.Shake)
				new Toast("Shake").Show();
		}

		private void SwitchView(TestBase instance)
		{
			if (instance.Equals(this.currentView))
				return;

			if (this.currentView != null)
			{
				this.currentView.Hide();
			}

			try
			{
				this.currentView = instance;

				this.currentView.Show();
				this.currentView.Dock = DockStyle.Fill;
				this.currentView.ViewRequested += View_ViewRequested;

				this.panelContainer.Controls.Add(this.currentView);
			}
			catch (Exception ex) 
			{
				AlertBox.Show(ex.Message);
			}

			if (instance is Integrations)
				this.buttonBack.Hide();
			else
				this.buttonBack.Show();

			if (Device.Valid)
				SetNativeColors();
		}

		private void View_ViewRequested(object sender, WidgetEventArgs e)
		{
			SwitchView(e.Data);
		}

		private void MainView_Disappear(object sender, EventArgs e)
		{
			Device.AppActions.ItemActivated -= AppActions_ItemActivated;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			SwitchView(this.integrations);
		}

		private void buttonTheme_Click(object sender, EventArgs e)
		{
			var name = Application.Theme.Name;
			LoadTheme(name == "Bootstrap-4");
		}

		private void LoadTheme(bool isDark)
		{
			if (isDark)
				Application.LoadTheme("BootstrapDark-4");
			else
				Application.LoadTheme("Bootstrap-4");

			if (Device.Valid)
				SetNativeColors();
		}
	}
}
