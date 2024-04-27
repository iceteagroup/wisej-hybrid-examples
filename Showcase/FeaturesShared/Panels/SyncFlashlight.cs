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

			if (Application.Uri.Host != "localhost")
				this.Pinned = true;
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
				var name = payload.name;

				AlertBox.Show($"Device: {name} toggled flashlight");

				if (on)
					Device.Flashlight.TurnOn();
				else
					Device.Flashlight.TurnOff();
			});
		}

		private void buttonOn_Click(object sender, EventArgs e)
		{
			OnToggleFlash(Device.Info.System.Model, true);
		}

		private void buttonOff_Click(object sender, EventArgs e)
		{
			OnToggleFlash(Device.Info.System.Model, false);
		}

		public static void OnToggleFlash(string name, bool on)
		{
			ToggleFlash?.Invoke(null, new { name, on });
		}

		public override bool IsSupported()
		{
			return Application.StartupUri.Host != "localhost";
		}
	}
}
