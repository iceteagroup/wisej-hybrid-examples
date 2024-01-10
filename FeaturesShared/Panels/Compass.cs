using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensors;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Compass : TestBase
	{
		public Compass()
		{
			InitializeComponent();
		}

		private void Compass_Appear(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Compass);
			Device.Sensors.CompassChanged += Compass_ReadingChanged;
		}

		private void Compass_Disappear(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Compass);
			Device.Sensors.CompassChanged -= Compass_ReadingChanged;
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Compass);
		}

		private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
		{
			this.labelHeading.Text = e.Reading.HeadingMagneticNorth.ToString();
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.Sensors.IsCompassSupported;
		}
	}
}
