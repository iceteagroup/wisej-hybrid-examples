using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Input")]
	public partial class Links : TestBase
	{
		public Links()
		{
			InitializeComponent();
		}

		private void buttonMailTo_Click(object sender, EventArgs e)
		{
			Application.Navigate("mailto:someone@yoursite.com");
		}

		private void buttonTel_Click(object sender, EventArgs e)
		{
			Application.Navigate("tel:123-456-7890");
		}

		private void buttonMaps_Click(object sender, EventArgs e)
		{
			Application.Navigate("http://maps.apple.com/?saddr=Cupertino&daddr=San+Francisco");
		}

		private void buttonNative_Click(object sender, EventArgs e)
		{
			Device.Browser.Open("https://wisej.com", Shared.Browser.BrowserLaunchMode.SystemPreferred);
		}
	}
}
