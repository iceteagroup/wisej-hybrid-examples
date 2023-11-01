using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensor;
using Wisej.Web;

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
			Device.Lifecycle.Resumed += Lifecycle_Resumed;
			Device.Sensors.ReadingChanged += Sensors_ReadingChanged;
		}

		private void Barometer_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Barometer);
			Device.Lifecycle.Resumed -= Lifecycle_Resumed;
			Device.Sensors.ReadingChanged -= Sensors_ReadingChanged;
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Barometer);
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			if (e.Sensor == SensorType.Barometer)
			{
				this.labelPressure.Text = e.Data.PressureInHectopascals.ToString();
			}
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sensors.IsBarometerSupported;
		}
	}
}
