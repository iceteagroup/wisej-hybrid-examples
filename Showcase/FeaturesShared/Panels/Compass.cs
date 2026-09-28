using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Compass : TestBase
	{
		public Compass()
		{
			InitializeComponent();
		}

		private void Compass_Appear(object sender, EventArgs e)
		{
			if (this._listening)
				return;

			Device.Sensors.CompassChanged += Compass_ReadingChanged;
			try
			{
				Device.Sensors.Start(SensorType.Compass);
				this._listening = true;
			}
			catch
			{
				Device.Sensors.CompassChanged -= Compass_ReadingChanged;
				throw;
			}
		}

		private bool _listening;

		private void Compass_Disappear(object sender, EventArgs e)
		{
			Deactivate();
		}

		public override void Deactivate()
		{
			if (!this._listening)
				return;

			this._listening = false;
			Device.Sensors.CompassChanged -= Compass_ReadingChanged;
			if (Device.Valid)
				Device.Sensors.Stop(SensorType.Compass);
		}


		private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
		{
			this.labelHeading.Text = e.Reading.HeadingMagneticNorth.ToString();
		}

	}
}
