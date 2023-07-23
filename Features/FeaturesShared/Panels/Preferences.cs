using System;
using System.ComponentModel;
using Wisej.Web;

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
			var savedValue = Device.Preferences.Get<string>("hybridtest");
			if (savedValue != null) 
				this.textBox1.Text = savedValue;
		}
	}
}
