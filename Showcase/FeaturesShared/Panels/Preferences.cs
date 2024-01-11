using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Storage")]
	public partial class Preferences : TestBase
	{
		public Preferences()
		{
			InitializeComponent();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Device.Preferences.Set("hybridtest", this.textBox1.Text);

			Device.Popups.DisplayAlert("Success", "The value has been saved to the device. Restart the app to see the value.", "OK");
		}

		private void Preferences_Load(object sender, EventArgs e)
		{
			if (Device.Preferences.ContainsKey("hybridtest"))
				this.textBox1.Text = Device.Preferences.Get("hybridtest", "");
		}
	}
}
