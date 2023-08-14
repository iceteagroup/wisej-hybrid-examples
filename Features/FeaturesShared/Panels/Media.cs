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

			this.pictureBox1.Image = picture;
		}

		private void buttonTakePicture_Click(object sender, EventArgs e)
		{
			var picture = Device.Media.CapturePhoto();

			this.pictureBox1.Image = picture;
		}

		private void buttonSelectVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.PickVideo();

			// todo.
		}

		private void buttonTakeVideo_Click(object sender, EventArgs e)
		{
			var video = Device.Media.CaptureVideo();

			// todo.
		}
	}
}
