using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class Magnetometer : TestBase
	{
		public Magnetometer()
		{
			InitializeComponent();
		}

		private void Magnetometer_Appear(object sender, EventArgs e)
		{
			if (this._listening)
				return;

			Device.Sensors.MagnetometerChanged += Magnetometer_ReadingChanged;
			try
			{
				Device.Sensors.Start(SensorType.Magnetometer);
				this._listening = true;
			}
			catch
			{
				Device.Sensors.MagnetometerChanged -= Magnetometer_ReadingChanged;
				throw;
			}
		}

		private bool _listening;

		private void Magnetometer_Disappear(object sender, EventArgs e)
		{
			Deactivate();
		}

		public override void Deactivate()
		{
			if (!this._listening)
				return;

			this._listening = false;
			Device.Sensors.MagnetometerChanged -= Magnetometer_ReadingChanged;
			if (Device.Valid)
				Device.Sensors.Stop(SensorType.Magnetometer);
		}


		private void Magnetometer_ReadingChanged(object sender, MagnetometerChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Reading.MagneticField.X}";
			this.labelY.Text = $"Y: {e.Reading.MagneticField.Y}";
			this.labelZ.Text = $"Z: {e.Reading.MagneticField.Z}";
		}

	}
}
