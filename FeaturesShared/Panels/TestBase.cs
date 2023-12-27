using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Wisej.Hybrid.Shared.Browser;
using Wisej.Web;

namespace Wisej.Hybrid.Features
{
	public partial class TestBase : UserControl
	{
		public event WidgetEventHandler ViewRequested;

		public void OnViewRequested(WidgetEventArgs e)
		{
			this.ViewRequested?.Invoke(this, e);
		}

		public TestBase()
		{
			InitializeComponent();
		}

		private void TestBase_Load(object sender, EventArgs e)
		{
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			Activate();

			if (Device.Valid)
			{
				ApplyOrientationSizing();
				Device.Sensors.OrientationSensorChanged += (s, e) => ApplyOrientationSizing();
			}

			this.labelTitle.Text = String.Join(" ", Regex.Split(this.GetType().Name, @"(?<!^)(?=[A-Z])"));
		}

		private void ApplyOrientationSizing()
		{
			var width = Application.Browser.Size.Width;
			var height = Application.Browser.Size.Height;

			var portrait = Math.Min(width, height) == width;

			if (!portrait)
				MinimizeTitle();	
			else
				MaximizeTitle();
		}

		public void MinimizeTitle()
		{
			if (this.labelTitle.Height != 60)
			{
				this.labelTitle.Height = 60;
				this.labelTitle.Font = new System.Drawing.Font("@windowTitleLandscape", 24, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			}
		}

		public void MaximizeTitle()
		{
			if (this.labelTitle.Height != 128)
			{
				this.labelTitle.Height = 128;
				this.labelTitle.Font = new System.Drawing.Font("@windowTitle", 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			}
		}

		private void buttonSource_Click(object sender, EventArgs e)
		{
			var name = this.GetType().Name;
			Device.Browser.Open($"https://github.com/iceteagroup/wisej-hybrid-examples/tree/main/FeaturesShared/Panels/{name}.cs", BrowserLaunchMode.SystemPreferred);
		}

		public virtual bool IsSupported()
		{
			return Device.Valid;
		}

		public virtual void Activate()
		{

		}

		public virtual void Deactivate()
		{

		}

		private void TestBase_VisibleChanged(object sender, EventArgs e)
		{
			if (this.Visible)
				Activate();
			else
				Deactivate();
		}
	}
}
