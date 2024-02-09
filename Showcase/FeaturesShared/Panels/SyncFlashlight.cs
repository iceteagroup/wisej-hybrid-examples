using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Hardware")]
	public partial class SyncFlashlight : TestBase
	{
		private static event EventHandler<dynamic> ToggleFlash;

		public SyncFlashlight()
		{
			InitializeComponent();
		}

		private void SyncFlashlight_Appear(object sender, EventArgs e)
		{
			ToggleFlash -= SyncFlashlight_ToggleFlash;
			ToggleFlash += SyncFlashlight_ToggleFlash;
		}

		private void SyncFlashlight_Disappear(object sender, EventArgs e)
		{
			Device.Flashlight.TurnOff();
			ToggleFlash -= SyncFlashlight_ToggleFlash;
		}

		private void SyncFlashlight_ToggleFlash(object sender, dynamic payload)
		{
			Application.Update(this, () =>
			{
				var on = payload.on;
				var model = payload.model;

				AlertBox.Show($"Device: {model} toggled flashlight");

				if (on)
				{
					Device.Flashlight.TurnOn();
				}
				else
				{
					Device.Flashlight.TurnOff();
				}
			});
		}

		private void buttonOn_Click(object sender, EventArgs e)
		{
			ToggleFlash?.Invoke(this, new { model = Device.Info.System.Model, on = true });
		}

		private void buttonOff_Click(object sender, EventArgs e)
		{
			ToggleFlash?.Invoke(this, new { model = Device.Info.System.Model, on = false });
		}

		public override bool IsSupported()
		{
			return Application.StartupUri.Host != "localhost";
		}
	}
}
