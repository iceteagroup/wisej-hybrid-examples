using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensors;

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
			Device.Sensors.Start(SensorType.Accelerometer);
			Device.Sensors.AccelerometerChanged += Accelerometer_ReadingChanged;
		}

		private void Accelerometer_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.AccelerometerChanged -= Accelerometer_ReadingChanged;
		}

		private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Reading.Acceleration.X}";
			this.labelY.Text = $"Y: {e.Reading.Acceleration.Y}";
			this.labelZ.Text = $"Z: {e.Reading.Acceleration.Z}";
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sensors.IsAccelerometerSupported;
		}
	}
}
