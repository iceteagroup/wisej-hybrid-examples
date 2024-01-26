#if !WINDOWS

using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using Wisej.Hybrid.DocumentScanner;
using Wisej.Hybrid.Modules.System;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class DocumentScanner : TestBase
	{
		private BindingSource data = new BindingSource();

		public DocumentScanner()
		{
			InitializeComponent();
		}

		private void buttonScan_Click(object sender, EventArgs e)
		{
			try
			{
				var scanner = Device.Use<DeviceDocumentScanner>();

				var imageScaleFactor = (float)this.trackBarQuality.Value / 10;
				foreach (var image in scanner.Scan(imageScaleFactor)) 
				{
					new ImageWindow(image).Show();
				}
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Message);
			}
		}

		public override bool IsSupported()
		{
			return Device.Info.System.Platform == DevicePlatform.iOS || 
				Device.Info.System.Platform == DevicePlatform.Android;
		}
	}
}

#endif