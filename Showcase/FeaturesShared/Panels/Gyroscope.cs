using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class Gyroscope : TestBase
	{
		public Gyroscope()
		{
			InitializeComponent();
		}

		private void Gyroscope_Appear(object sender, EventArgs e)
		{
			if (this._listening)
				return;

			Device.Sensors.GyroscopeChanged += Gyroscope_ReadingChanged;
			try
			{
				Device.Sensors.Start(SensorType.Gyroscope);
				this._listening = true;
			}
			catch
			{
				Device.Sensors.GyroscopeChanged -= Gyroscope_ReadingChanged;
				throw;
			}
		}

		private bool _listening;

		private void Gyroscope_Disappear(object sender, EventArgs e)
		{
			Deactivate();
		}

		public override void Deactivate()
		{
			if (!this._listening)
				return;

			this._listening = false;
			Device.Sensors.GyroscopeChanged -= Gyroscope_ReadingChanged;
			if (Device.Valid)
				Device.Sensors.Stop(SensorType.Gyroscope);
		}

		private void Gyroscope_ReadingChanged(object sender, GyroscopeChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Reading.AngularVelocity.X}";
			this.labelY.Text = $"Y: {e.Reading.AngularVelocity.Y}";
			this.labelZ.Text = $"Z: {e.Reading.AngularVelocity.Z}";
		}

	}
}
