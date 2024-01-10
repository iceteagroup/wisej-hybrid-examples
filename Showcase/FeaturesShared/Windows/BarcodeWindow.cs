using System;
using Wisej.Web;
using Wisej.Hybrid.MLKit;

namespace FeaturesShared
{
	public partial class BarcodeWindow : Form
	{
		public BarcodeWindow()
		{
			InitializeComponent();
		}

		private void barcodeScanner1_Recognized(object sender, BarcodesRecognizedEventArgs e)
		{
			this.textBoxRecent.Text += JSON.Stringify(e.Results);
			this.textBoxRecent.ScrollToY(1000);
		}
	}
}
