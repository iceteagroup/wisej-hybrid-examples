using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class Audio : TestBase
	{
		public Audio()
		{
			InitializeComponent();
		}

		private void buttonPlayAudio_Click(object sender, EventArgs e)
		{
			Application.Play("Data/bell.mp3");
		}
	}
}
