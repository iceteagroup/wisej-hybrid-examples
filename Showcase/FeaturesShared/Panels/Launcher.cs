using System;
using System.ComponentModel;
using System.IO;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Launcher : TestBase
	{
		public Launcher()
		{
			InitializeComponent();
		}

		private void buttonOpenImage_Click(object sender, EventArgs e)
		{
			using (var file = new FileStream(Application.MapPath("Images/wisej.png"), FileMode.Open))
			{
				using (var ms = new MemoryStream())
				{
					file.CopyTo(ms);

					Device.Launcher.Open("Image", "wisej.png", ms.ToArray());
				}
			}
		}

		private void buttonOpenPdf_Click(object sender, EventArgs e)
		{
			using (var file = new FileStream(Application.MapPath("Data/wisej.pdf"), FileMode.Open))
			{
				using (var ms = new MemoryStream())
				{
					file.CopyTo(ms);

					Device.Launcher.Open("Image", "wisej.pdf", ms.ToArray());
				}
			}
		}
	}
}
