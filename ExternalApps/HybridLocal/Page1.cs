using Wisej.Hybrid;
using Wisej.Hybrid.Modules.System;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void buttonLyft_Click(object sender, System.EventArgs e)
		{
			if (Device.Launcher.CanOpen("lyft://ridetype?id=lyft_line"))
				Device.Launcher.Open("lyft://ridetype?id=lyft_line");
		}

		private void buttonMaps_Click(object sender, System.EventArgs e)
		{
			var url = "http://maps.google.com/?q=40.7128,-74.0060";

			if (Device.Info.System.Platform == DevicePlatform.iOS)
				url = "maps://?q=40.7128,-74.0060";

			Device.Launcher.Open(url);
		}

		private void buttonFb_Click(object sender, System.EventArgs e)
		{
			if (Device.Launcher.CanOpen("fb://"))
				Device.Launcher.Open("fb://");
		}
	}
}
