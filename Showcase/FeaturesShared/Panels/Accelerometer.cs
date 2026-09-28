using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class Accelerometer : TestBase
	{
		public Accelerometer()
		{
			InitializeComponent();
		}

		private void Accelerometer_Appear(object sender, EventArgs e)
		{
			if (this._listening)
				return;

			Device.Sensors.AccelerometerChanged += Accelerometer_ReadingChanged;
			try
			{
				Device.Sensors.Start(SensorType.Accelerometer);
				this._listening = true;
			}
			catch
			{
				Device.Sensors.AccelerometerChanged -= Accelerometer_ReadingChanged;
				throw;
			}
		}

		private bool _listening;

		private void Accelerometer_Disappear(object sender, EventArgs e)
		{
			Deactivate();
		}

		public override void Deactivate()
		{
			if (!this._listening)
				return;

			this._listening = false;
			Device.Sensors.AccelerometerChanged -= Accelerometer_ReadingChanged;
			if (Device.Valid)
				Device.Sensors.Stop(SensorType.Accelerometer);
		}

		private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Reading.Acceleration.X}";
			this.labelY.Text = $"Y: {e.Reading.Acceleration.Y}";
			this.labelZ.Text = $"Z: {e.Reading.Acceleration.Z}";
		}

	}
}
