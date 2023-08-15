using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using Wisej.Web;

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
			var picture = Device.Media.PickPhoto();

			new ImageWindow(picture).Show();
		}

		private void buttonTakePicture_Click(object sender, EventArgs e)
		{
			var picture = Device.Media.CapturePhoto();

			new ImageWindow(picture).Show();
		}

		private void buttonSelectVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.PickVideo();

			new VideoWindow(video.ToArray()).Show();
		}

		private void buttonTakeVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.CaptureVideo();

			new VideoWindow(video.ToArray()).Show();
		}
	}
}
