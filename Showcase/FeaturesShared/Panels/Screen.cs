using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using System.IO;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Screen : TestBase
	{
		private bool _recording;
		private bool _recordingSupported;
		private bool _recordingBusy;
		private readonly Label _status = new() { Dock = DockStyle.Top, Height = 44 };

		public Screen()
		{
			InitializeComponent();
			buttonRecording.Enabled = buttonStopRecording.Enabled = false;
			Controls.Add(_status);
			_status.BringToFront();
			Disposed += Screen_Disposed;
		}

		private async void Screen_Load(object sender, EventArgs e)
		{
			Device.Screen.Recording += Screen_Recording;
			Device.Screen.RecordingFailed += Screen_RecordingFailed;
			try
			{
				_recordingSupported = await Device.Screen.IsRecordingSupportedAsync();
				if (IsDisposed) return;
				buttonScreenshot.Enabled = Device.Screen.IsCaptureSupported;
				_status.Text = _recordingSupported ? "Ready to capture." : "Screen recording is unavailable on this device.";
			}
			catch (Exception error) { if (!IsDisposed) _status.Text = error.Message; }
			finally { UpdateButtons(); }
		}

		private async void buttonStopRecording_Click(object sender, EventArgs e)
		{
			if (_recordingBusy || !_recording) return;
			_recordingBusy = true;
			UpdateButtons();
			_status.Text = "Preparing video…";
			try
			{
				var video = await Device.Screen.StopRecordingAsync();
				_recording = false;
				if (IsDisposed) return;
				_status.Text = "Recording complete.";
				if (video.Length > 0) new VideoWindow(video).Show();
			}
			catch (Exception error) { _recording = false; if (!IsDisposed) _status.Text = error.Message; }
			finally { _recordingBusy = false; UpdateButtons(); }
		}

		private async void buttonScreenshot_Click(object sender, EventArgs e)
		{
			if (!buttonScreenshot.Enabled) return;
			buttonScreenshot.Enabled = false;
			try
			{
				var image = await Device.Screen.CapturePhotoAsync();
				if (IsDisposed) image?.Dispose();
				else if (image != null) new ImageWindow(image).Show();
			}
			catch (Exception error) { if (!IsDisposed) _status.Text = error.Message; }
			finally { if (!IsDisposed) buttonScreenshot.Enabled = true; }
		}

		private async void buttonRecord_Click(object sender, EventArgs e)
		{
			if (_recordingBusy || _recording || !_recordingSupported) return;
			_recordingBusy = true;
			UpdateButtons();
			try
			{
				_recording = await Device.Screen.StartRecordingAsync(false);
				if (IsDisposed)
				{
					if (_recording && Device.Valid) Device.Screen.StopRecording();
					_recording = false;
					return;
				}
				_status.Text = _recording ? "Recording. Use Stop Recording to preview the video." : "Recording cancelled.";
			}
			catch (Exception error) { if (!IsDisposed) _status.Text = error.Message; }
			finally { _recordingBusy = false; UpdateButtons(); }
		}

		private void UpdateButtons()
		{
			if (IsDisposed) return;
			buttonRecording.Enabled = !_recordingBusy && _recordingSupported && !_recording;
			buttonStopRecording.Enabled = !_recordingBusy && _recording;
		}

		private void Screen_Recording(object sender, MemoryStream video)
		{
			using (video)
			{
				if (IsDisposed) return;
				_recording = false;
				_status.Text = "Recording complete.";
				new VideoWindow(video.ToArray()).Show();
				UpdateButtons();
			}
		}

		private void Screen_RecordingFailed(object sender, DeviceException error)
		{
			if (IsDisposed) return;
			_recording = false;
			_status.Text = error.Message;
			UpdateButtons();
		}

		private void Screen_Disposed(object sender, EventArgs e)
		{
			Device.Screen.Recording -= Screen_Recording;
			Device.Screen.RecordingFailed -= Screen_RecordingFailed;
			if (_recording && !_recordingBusy && Device.Valid) Device.Screen.StopRecording();
			_recording = false;
		}
	}
}
