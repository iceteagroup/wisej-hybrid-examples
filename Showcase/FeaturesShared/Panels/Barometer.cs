using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensors;

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
			Device.Sensors.Start(SensorType.Barometer);
			Device.Sensors.BarometerChanged += Barometer_ReadingChanged;
		}

		private void Barometer_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Barometer);
			Device.Sensors.BarometerChanged -= Barometer_ReadingChanged;
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Barometer);
		}

		private void Barometer_ReadingChanged(object sender, BarometerChangedEventArgs e)
		{
			this.labelPressure.Text = e.Reading.PressureInHectopascals.ToString();
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sensors.IsBarometerSupported;
		}
	}
}
