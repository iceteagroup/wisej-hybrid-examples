using System;
using System.Collections.Generic;
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
			var files = new Dictionary<string, Stream>();

			var path1 = Application.MapPath("Images/wisej.png");
			files.Add("wisej.png", Device.Resources.GetStream(path1));

			var path2 = Application.MapPath("Images/logo-wisej-white.png");
			files.Add("Images/logo-wisej-white.png", Device.Resources.GetStream(path2));

			Device.Sharing.ShareFiles("Share Files", files);
		}
	}
}
