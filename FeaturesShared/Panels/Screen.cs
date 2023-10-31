using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Screen : TestBase
	{
		public Screen()
		{
			InitializeComponent();
		}

		private void Screen_Load(object sender, EventArgs e)
		{
			Device.Screen.Recording += Screen_Recording;
		}

		private void buttonStopRecording_Click(object sender, EventArgs e)
		{
			Device.Screen.StopRecording();
		}

		private void buttonScreenshot_Click(object sender, EventArgs e)
		{
			var image = Device.Screen.CapturePhoto();

			new ImageWindow(image).Show();
		}

		private void buttonRecord_Click(object sender, EventArgs e)
		{
			if (Device.Screen.StartRecording(false))
				MessageBox.Show($"Recording has started. Click around the app and come back.", "Recording");
		}

		private void Screen_Recording(object sender, System.IO.MemoryStream e)
		{
			//this.pictureBox1.Image = Image.FromStream(e);
		}
	}
}
