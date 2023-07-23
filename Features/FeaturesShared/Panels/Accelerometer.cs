using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensor;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	
	public partial class Accelerometer : TestBase
	{
		public Accelerometer()
		{
			InitializeComponent();
		}

		private void Accelerometer_Load(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Accelerometer);
			Device.Sensors.ReadingChanged += Sensors_ReadingChanged;
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			this.labelX.Text = $"X: {e.Data.Acceleration.X}";
			this.labelY.Text = $"Y: {e.Data.Acceleration.Y}";
			this.labelZ.Text = $"Z: {e.Data.Acceleration.Z}";
		}

		private void Accelerometer_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.ReadingChanged -= Sensors_ReadingChanged;
		}

		public override bool IsSupported()
		{
			return Device.Sensors.IsSupported(SensorType.Accelerometer);
		}
	}
}
