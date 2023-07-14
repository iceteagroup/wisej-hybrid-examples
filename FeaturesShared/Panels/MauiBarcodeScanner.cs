using System;
using System.ComponentModel;
using Wisej.Hybrid.Scanners;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class MauiBarcodeScanner : TestBase
	{
		public MauiBarcodeScanner()
		{
			InitializeComponent();
		}

		private void buttonScan_Click(object sender, EventArgs e)
		{
			var options = new BarcodeReaderOptions
			{
				AutoRotate = true,
				Multiple = true,
			};

			var barcodes = Device.Use<DeviceScanners>().ScanBarcodes(options);

			AlertBox.Show($"<b>Scanned:</b><br>{string.Join("<br>", barcodes)}", allowHtml: true);
		}
	}
}
