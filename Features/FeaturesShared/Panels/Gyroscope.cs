using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensor;

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
			Device.Sensors.Start(SensorType.Gyroscope);
			Device.Lifecycle.Resumed += Lifecycle_Resumed;
			Device.Sensors.ReadingChanged += Sensors_ReadingChanged;
		}

		private void Gyroscope_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Gyroscope);
			Device.Lifecycle.Resumed -= Lifecycle_Resumed;
			Device.Sensors.ReadingChanged -= Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding -= Lifecycle_Backgrounding;
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Gyroscope);
		}

		private void Lifecycle_Backgrounding(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Gyroscope);
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			if (e.Sensor == SensorType.Gyroscope)
			{
				this.labelX.Text = $"X: {e.Data.AngularVelocity.X}";
				this.labelY.Text = $"Y: {e.Data.AngularVelocity.Y}";
				this.labelZ.Text = $"Z: {e.Data.AngularVelocity.Z}";
			}
		}

		public override bool IsSupported()
		{
			return Device.Sensors.IsSupported(SensorType.Gyroscope);
		}
	}
}
