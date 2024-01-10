using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using System.IO;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class Media : TestBase
	{
		public Media()
		{
			InitializeComponent();
		}

		private void buttonSelectPicture_Click(object sender, EventArgs e)
		{
			var picture = Device.Media.PickPhoto(0.5);

			new ImageWindow(System.Drawing.Image.FromStream(new MemoryStream(picture))).Show();
		}

		private void buttonTakePicture_Click(object sender, EventArgs e)
		{
			var picture = Device.Media.CapturePhoto(0.5);

			new ImageWindow(System.Drawing.Image.FromStream(new MemoryStream(picture))).Show();
		}

		private void buttonSelectVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.PickVideo(0.5);

			//new VideoWindow(video.ToArray()).Show();
		}

		private void buttonTakeVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.CaptureVideo(0.5);

			//new VideoWindow(video.ToArray()).Show();
		}
	}
}
