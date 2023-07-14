using System;
using System.ComponentModel;
using System.IO;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class Sharing : TestBase
	{
		public Sharing()
		{
			InitializeComponent();
		}

		private void buttonText_Click(object sender, EventArgs e)
		{
			Device.Sharing.ShareText("Share Text", this.textBoxText.Text);
		}

		private void buttonUri_Click(object sender, EventArgs e)
		{
			Device.Sharing.ShareUri("Share Uri", this.textBoxUri.Text);
		}

		private void buttonFiles_Click(object sender, EventArgs e)
		{
			var files = new FileStream[2];

			var path1 = Application.MapPath("Images/wisej.png");
			files[0] = new FileStream(path1, FileMode.Open);

			var path2 = Application.MapPath("Images/logo-wisej-white.png");
			files[1] = new FileStream(path2, FileMode.Open);

			Device.Sharing.ShareFiles("Share Files", files);

			files[0].Dispose();
			files[1].Dispose();
		}
	}
}
