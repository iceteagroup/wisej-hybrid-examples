using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensors;

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
			Device.Sensors.Start(SensorType.Magnetometer);
			Device.Sensors.MagnetometerChanged += Magnetometer_ReadingChanged;
		}

		private void Magnetometer_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Magnetometer);
			Device.Sensors.MagnetometerChanged -= Magnetometer_ReadingChanged;
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Magnetometer);
		}

		private void Magnetometer_ReadingChanged(object sender, MagnetometerChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Reading.MagneticField.X}";
			this.labelY.Text = $"Y: {e.Reading.MagneticField.Y}";
			this.labelZ.Text = $"Z: {e.Reading.MagneticField.Z}";
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sensors.IsMagnetometerSupported;
		}
	}
}
