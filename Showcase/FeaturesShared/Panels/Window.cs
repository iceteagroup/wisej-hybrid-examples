using System;
using System.ComponentModel;
using Wisej.Hybrid;


namespace FeaturesShared.Panels
{
	[Category("UI")]
	public partial class Window : Wisej.Hybrid.Features.TestBase
	{
		public Window()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Device.Windows.TryOpen(this.textBoxUrl.Text);
		}

		public override bool IsSupported()
		{
			return Device.Valid && 
			// iPhone doesn't support multiple windows.
			(Device.System.Platform != DevicePlatform.iOS || Device.System.Idiom == DeviceIdiom.Tablet);
		}
	}
}
