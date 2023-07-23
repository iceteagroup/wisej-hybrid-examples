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

		private void Barometer_Load(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Barometer);
			Device.Lifecycle.Resumed += Lifecycle_Resumed;
			Device.Sensors.ReadingChanged += Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding += Lifecycle_Backgrounding;	
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Barometer);
		}

		private void Lifecycle_Backgrounding(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Barometer);
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			if (e.Sensor == SensorType.Barometer)
			{
				this.labelPressure.Text = e.Data.PressureInHectopascals.ToString();
			}
		}

		private void Barometer_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Barometer);
			Device.Lifecycle.Resumed -= Lifecycle_Resumed;
			Device.Sensors.ReadingChanged -= Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding -= Lifecycle_Backgrounding;
		}

		public override bool IsSupported()
		{
			return Device.Sensors.IsSupported(SensorType.Barometer);
		}
	}
}
