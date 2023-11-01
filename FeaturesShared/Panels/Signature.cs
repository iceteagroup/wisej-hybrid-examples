using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Wisej.Hybrid;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Input")]
	public partial class Signature : Wisej.Hybrid.Features.TestBase
	{
		public Signature()
		{
			InitializeComponent();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.signature1.Clear();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var image = await this.signature1.GetImageAsync();

			// workaround until Application.Download(image) is fixed.
			var path = Path.Combine(Device.Info.FileSystem.CacheDirectory, "signature.png");
			image.Save(path, ImageFormat.Png);

			Application.DownloadAndOpen("_blank", path);
		}

		private void textBoxColor_TextChanged(object sender, EventArgs e)
		{
			this.signature1.LineColor = ColorTranslator.FromHtml(this.textBoxColor.Text);
		}

		private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
		{
			this.signature1.LineWidth = (int)this.numericUpDownWidth.Value;
		}

		private void buttonUndo_Click(object sender, EventArgs e)
		{
			this.signature1.Undo();
		}

		private void buttonRedo_Click(object sender, EventArgs e)
		{
			this.signature1.Redo();
		}
	}
}
