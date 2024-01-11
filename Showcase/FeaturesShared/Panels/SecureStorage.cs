using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Storage")]
	public partial class SecureStorage : TestBase
	{
		public SecureStorage()
		{
			InitializeComponent();
		}

		private void SecureStorage_Load(object sender, EventArgs e)
		{
			var savedValue = Device.SecureStorage.Get("hybridtest");
			if (savedValue != null)
				this.textBox1.Text = savedValue;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			Device.SecureStorage.Set("hybridtest", this.textBox1.Text);

			Device.Popups.DisplayAlert("Success", "The value has been saved to the device. Restart the app to see the value.", "OK");
		}
	}
}
