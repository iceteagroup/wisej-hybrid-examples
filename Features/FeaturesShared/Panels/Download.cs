using System;
using System.ComponentModel;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Storage")]
	public partial class Download : TestBase
	{
		public Download()
		{
			InitializeComponent();
		}

		private void buttonImage_Click(object sender, EventArgs e)
		{
			Application.Download(Application.MapPath("Images/wisej.png"));
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			Application.DownloadAndOpen("_self", Application.MapPath("Data/wisej.pdf"));
		}
	}
}
