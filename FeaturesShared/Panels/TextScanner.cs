using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.MLKit;
using Wisej.Hybrid.MLKit.Shared;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Hardware")]
	public partial class TextScanner : TestBase
	{
		public TextScanner()
		{
			InitializeComponent();
		}

		private void buttonNative_Click(object sender, EventArgs e)
		{
			Device.Use<DeviceML>().ScanText(new CaptureConfiguration());
		}

		private void buttonEmbedded_Click(object sender, EventArgs e)
		{
			new TextWindow().Show();
		}

		public override bool IsSupported()
		{
			return Device.Valid &&
				(Device.Info.System.Platform == "iOS" ||
				Device.Info.System.Platform == "Android");
		}
	}
}
