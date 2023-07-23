using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class Flashlight : TestBase
	{
		public Flashlight()
		{
			InitializeComponent();
		}

		private void buttonOn_Click(object sender, EventArgs e)
		{
			Device.Flashlight.TurnOn();
		}

		private void buttonOff_Click(object sender, EventArgs e)
		{
			Device.Flashlight.TurnOff();
		}

		private void Flashlight_Disposed(object sender, EventArgs e)
		{
			Device.Flashlight.TurnOff();
		}
	}
}
