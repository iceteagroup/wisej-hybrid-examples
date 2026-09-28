using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.MLKit;
using Wisej.Hybrid.MLKit.Shared;

using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Hardware")]
	public partial class BarcodeScanner : TestBase
	{
		private readonly ListBox _results = new() { Dock = DockStyle.Fill };
		private readonly Label _status = new() { Dock = DockStyle.Top, Height = 42, Text = "Scan a single code, or collect a batch." };

		public BarcodeScanner()
		{
			InitializeComponent();
			buttonNative.Text = "Scan one code";
			buttonEmbedded.Text = "Scan a batch";
			buttonNative.Height = buttonEmbedded.Height = 48;
			Hint = "Point your camera at a barcode or QR code. Scanned values stay here until you clear them.";
			var resultsPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 20, 0, 0) };
			var clear = new Button { Text = "Clear results", Dock = DockStyle.Bottom, Height = 44 };
			clear.Click += (_, _) => { _results.Items.Clear(); _status.Text = "Ready for your next scan."; };
			resultsPanel.Controls.Add(_results);
			resultsPanel.Controls.Add(_status);
			resultsPanel.Controls.Add(clear);
			Controls.Add(resultsPanel);
			resultsPanel.BringToFront();
		}

		public override void Activate() { base.Activate(); MinimizeTitle(); }

		private void buttonNative_Click(object sender, EventArgs e) => Scan(false);
		private void buttonEmbedded_Click(object sender, EventArgs e) => Scan(true);

		private void Scan(bool multiple)
		{
			buttonNative.Enabled = buttonEmbedded.Enabled = false;
			try
			{
				// Keep the server in its modal loop while the native scanner is open,
				// so its result can return even when the client is showing a loader.
				var values = Device.Use<DeviceML>().ScanBarcode(new CaptureConfiguration
				{
					AllowMultiple = multiple, UniqueCapturesOnly = true
				});
				foreach (var value in values ?? Array.Empty<string>()) _results.Items.Add(value);
				_status.Text = values?.Length > 0 ? $"Added {values.Length} code(s). {_results.Items.Count} total." : "No codes added. Ready when you are.";
			}
			catch (Exception error) { _status.Text = error.Message; }
			finally { buttonNative.Enabled = buttonEmbedded.Enabled = true; }
		}

		public override bool IsSupported() => base.IsSupported();
	}
}
