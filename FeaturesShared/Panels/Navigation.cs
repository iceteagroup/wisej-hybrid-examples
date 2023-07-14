using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Navigation : TestBase
	{
		public Navigation()
		{
			InitializeComponent();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			var args = this.textBoxTitle.Text;

			var result = Device.Navigation.PushModal("Wisej.Hybrid.Maui.TestPage, Wisej.Hybrid.MauiApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", true, args);

			AlertBox.Show(result);
		}
	}
}
