using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Sensor;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class Magnetometer : TestBase
	{
		public Magnetometer()
		{
			InitializeComponent();
		}

		private void Magnetometer_Load(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Magnetometer);
			Device.Lifecycle.Resumed += Lifecycle_Resumed;
			Device.Sensors.ReadingChanged += Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding += Lifecycle_Backgrounding;
		}

		private void Lifecycle_Backgrounding(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Magnetometer);
		}

		private void Lifecycle_Resumed(object sender, EventArgs e)
		{
			Device.Sensors.Start(SensorType.Magnetometer);
		}

		private void Sensors_ReadingChanged(object sender, SensorChangedEventArgs e)
		{
			if (e.Sensor == SensorType.Magnetometer)
			{
				this.labelX.Text = $"X: {e.Data.MagneticField.X}";
				this.labelY.Text = $"Y: {e.Data.MagneticField.Y}";
				this.labelZ.Text = $"Z: {e.Data.MagneticField.Z}";
			}
		}

		private void Magnetometer_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.Stop(SensorType.Magnetometer);
			Device.Lifecycle.Resumed -= Lifecycle_Resumed;
			Device.Sensors.ReadingChanged -= Sensors_ReadingChanged;
			Device.Lifecycle.Backgrounding -= Lifecycle_Backgrounding;
		}
	}
}
