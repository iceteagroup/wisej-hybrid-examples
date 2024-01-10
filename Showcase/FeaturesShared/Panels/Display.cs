using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("UI")]
	public partial class Display : TestBase
	{
		public Display()
		{
			InitializeComponent();
		}

		private void checkBoxKeepOn_CheckedChanged(object sender, EventArgs e)
		{
			Device.Display.KeepOn = this.checkBoxKeepOn.Checked;
		}
	}
}
