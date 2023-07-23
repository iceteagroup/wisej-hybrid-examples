using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensor;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Compass : TestBase
	{
		public Compass()
		{
			InitializeComponent();
		}

		private void Compass_Load(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Compass);
			Device.Lifecycle.Resumed += Lifecycle_Resumed;
			Device.Sensors.ReadingChanged += Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding += Lifecycle_Backgrounding;
		}

		private void Lifecycle_Backgrounding(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Compass);
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Compass);
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			if (e.Sensor == SensorType.Compass)
			{
				this.labelHeading.Text = e.Data.HeadingMagneticNorth.ToString();
			}
		}

		private void Compass_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Compass);
			Device.Lifecycle.Resumed -= Lifecycle_Resumed;
			Device.Sensors.ReadingChanged -= Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding -= Lifecycle_Backgrounding;
		}

		public override bool IsSupported()
		{
			return Device.Sensors.IsSupported(SensorType.Compass);
		}
	}
}
