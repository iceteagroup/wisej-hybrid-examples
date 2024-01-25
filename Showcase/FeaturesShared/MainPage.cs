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

using FeaturesShared.Windows;
using System;
using System.Drawing;
using Wisej.Ext.MaterialDesign;
using Wisej.Hybrid.Features.Panels;
using Wisej.Hybrid.Shared.Communication;
using Wisej.Hybrid.Shared.StatusBar;
using Wisej.Web;

namespace Wisej.Hybrid.Features
{
	public partial class MainPage : Page
	{
		private TestBase currentView;

		private Integrations _integrations = new Integrations();

		public MainPage()
		{
			InitializeComponent();
		}

		private async void MainPage_Load(object sender, EventArgs e)
		{
			var x = new Popups();
			var loader = new LoadingWindow();
			loader.Show();

			// set padding for device.
			if (Application.Browser.Device == "Desktop")
				this.panelContainer.Padding = new Padding(16, 16, 16, 16);

			LoadTheme(Application.Browser.IsDarkMode);

			var offline = Application.Uri.Host == "localhost";
			this.buttonNetwork.Text = offline ? "Offline" : "Online";
			this.buttonNetwork.ImageSource = offline ? Icons.CloudOff : Icons.CloudOutline;

			// default view.
			SwitchView(this._integrations);
			await this._integrations.Initialize();

			loader.Dispose();
			Application.Update(this);
		}

		private void MainPage_Appear(object sender, EventArgs e)
		{
			if (Device.Valid)
				SetNativeColors();
		}

		private void SetNativeColors()
		{
			var theme = Application.Theme.Colors.window;
			var window = ColorTranslator.FromHtml(theme);

			Device.StatusBar.BackColor = window;
			Device.BottomBar.BackColor = window;
			Device.Background.BackColor = window;

			if (Application.Theme.Name == "Bootstrap-4")
				Device.StatusBar.TextColor = StatusBarTextColor.Black;
			else
				Device.StatusBar.TextColor = StatusBarTextColor.White;
		}

		private void SwitchView(TestBase instance)
		{
			if (instance == null || instance.Equals(this.currentView))
				return;

			if (this.currentView != null)
				this.currentView.Hide();

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

		private void buttonBack_Click(object sender, EventArgs e)
		{
			SwitchView(this._integrations);
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

		private void buttonNetwork_Click(object sender, EventArgs e)
		{
			if (Device.Valid)
			{
				var offline = Application.Uri.Host == "localhost";
				if (offline)
				{
					if (Device.Info.Networking.NetworkAccess == NetworkAccess.Internet)
					{
						var result = Device.Popups.DisplayActionSheet("Reconnect to server?", "No", "Yes", Shared.FlowDirection.LeftToRight, new string[] { });
						if (result == "Yes")
							Application.Navigate("https://demo.wisej.com/Hybrid");
					}
					else
					{
						MessageBox.Show("Network Connection Unavailable", "Network");
					}
				}
				else
				{
					var result = Device.Popups.DisplayActionSheet("Go offline?", "No", "Yes", Shared.FlowDirection.LeftToRight, new string[] { });
					if ( result == "Yes")
					{
						Application.Navigate("http://localhost:5000");
					}
				}
			}
		}
	}
}
