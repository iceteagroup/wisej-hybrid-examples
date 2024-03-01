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
			var picture = Device.Media.PickPhoto(1280, 720);

			new ImageWindow(picture).Show();
		}

		private void buttonTakePicture_Click(object sender, EventArgs e)
		{
			var picture = Device.Media.CapturePhoto(1280, 720);

			new ImageWindow(picture).Show();
		}

		private void buttonSelectVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.PickVideo();

			//new VideoWindow(video.ToArray()).Show();
		}

		private void buttonTakeVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.CaptureVideo();

			//new VideoWindow(video.ToArray()).Show();
		}
	}
}
