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
			Device.Launcher.Open("lyft://ridetype?id=lyft_line");
		}

		private void buttonMaps_Click(object sender, System.EventArgs e)
		{
			var coordinates = "40.726966,-74.006076";

			var url = $"geo:{coordinates}";

			if (Device.Info.System.IsApple)
				url = $"maps://?q={coordinates}";

			Device.Launcher.Open(url);
		}

		private void buttonFb_Click(object sender, System.EventArgs e)
		{
			Device.Launcher.Open("fb://");
		}
	}
}
