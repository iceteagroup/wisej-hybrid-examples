using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class Barometer : TestBase
	{
		public Barometer()
		{
			InitializeComponent();
		}

		private void Barometer_Appear(object sender, EventArgs e)
		{
			if (this._listening)
				return;

			Device.Sensors.BarometerChanged += Barometer_ReadingChanged;
			try
			{
				Device.Sensors.Start(SensorType.Barometer);
				this._listening = true;
			}
			catch
			{
				Device.Sensors.BarometerChanged -= Barometer_ReadingChanged;
				throw;
			}
		}

		private bool _listening;

		private void Barometer_Disappear(object sender, EventArgs e)
		{
			Deactivate();
		}

		public override void Deactivate()
		{
			if (!this._listening)
				return;

			this._listening = false;
			Device.Sensors.BarometerChanged -= Barometer_ReadingChanged;
			if (Device.Valid)
				Device.Sensors.Stop(SensorType.Barometer);
		}


		private void Barometer_ReadingChanged(object sender, BarometerChangedEventArgs e)
		{
			this.labelPressure.Text = e.Reading.PressureInHectopascals.ToString();
		}

	}
}
