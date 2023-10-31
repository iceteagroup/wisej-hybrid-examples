using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Alerts")]
	public partial class Speech : TestBase
	{
		public Speech()
		{
			InitializeComponent();
		}

		private void buttonSpeak_Click(object sender, EventArgs e)
		{
			Device.Speech.Speak(this.textBoxText.Text);
		}
	}
}
