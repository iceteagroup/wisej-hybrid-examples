using System;
using Wisej.Web;
using Wisej.Hybrid.MLKit;

namespace FeaturesShared
{
	public partial class TextWindow : Form
	{
		public TextWindow()
		{
			InitializeComponent();
		}

		private void textScanner1_Recognized(object sender, TextRecognizedEventArgs e)
		{
			this.textBoxRecent.Text += JSON.Stringify(e.Results);
			this.textBoxRecent.ScrollToY(1000);
		}
	}
}
