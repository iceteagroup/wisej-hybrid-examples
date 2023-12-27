using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensors;

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
			Device.Sensors.GyroscopeChanged += Gyroscope_ReadingChanged;
		}

		private void Gyroscope_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Gyroscope);
			Device.Sensors.GyroscopeChanged -= Gyroscope_ReadingChanged;
		}

		private void Gyroscope_ReadingChanged(object sender, GyroscopeChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Reading.AngularVelocity.X}";
			this.labelY.Text = $"Y: {e.Reading.AngularVelocity.Y}";
			this.labelZ.Text = $"Z: {e.Reading.AngularVelocity.Z}";
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sensors.IsGyroscopeSupported;
		}
	}
}
