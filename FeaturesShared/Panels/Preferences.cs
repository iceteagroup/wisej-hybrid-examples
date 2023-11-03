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
		}

		private void Preferences_Load(object sender, EventArgs e)
		{
			if (Device.Preferences.ContainsKey("hybridtest"))
				this.textBox1.Text = Device.Preferences.Get("hybridtest", "");
		}
	}
}
