using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class Media : TestBase
	{
		private bool _busy;

		public Media()
		{
			InitializeComponent();
		}

		private async void buttonPhoto_Click(object sender, EventArgs e)
		{
			if (_busy) return;
			SetBusy(true);
			try
			{
				var picture = sender == buttonTakePicture
					? await Device.Media.CapturePhotoAsync(1280, 720)
					: await Device.Media.PickPhotoAsync(1280, 720);
				if (IsDisposed) picture?.Dispose();
				else if (picture != null) new ImageWindow(picture).Show();
			}
			catch (Exception error) { if (!IsDisposed) AlertBox.Show(error.Message); }
			finally { SetBusy(false); }
		}

		private async void buttonVideo_Click(object sender, EventArgs e)
		{
			if (_busy) return;
			SetBusy(true);
			try
			{
				var video = sender == buttonTakeVideo
					? await Device.Media.CaptureVideoAsync()
					: await Device.Media.PickVideoAsync();
				if (!IsDisposed && video?.Length > 0) new VideoWindow(video).Show();
			}
			catch (Exception error) { if (!IsDisposed) AlertBox.Show(error.Message); }
			finally { SetBusy(false); }
		}

		private void SetBusy(bool busy)
		{
			_busy = busy;
			if (IsDisposed) return;
			buttonSelectPicture.Enabled = buttonTakePicture.Enabled =
				buttonSelectVideo.Enabled = buttonTakeVideo.Enabled = !busy;
		}
	}
}
