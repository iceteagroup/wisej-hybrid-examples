using System;
using System.ComponentModel;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Information")]
	public partial class DeviceInfo : TestBase
	{
		public DeviceInfo()
		{
			InitializeComponent();
		}

		private void DeviceInfo_Load(object sender, EventArgs e)
		{
			this.propertyGridInfo.SelectedObject = Device.Info;

			Device.Battery.BatteryInfoChanged += Device_InfoChanged;
			Device.Networking.ConnectivityChanged += Device_InfoChanged;
			Device.Display.MainDisplayInfoChanged += Device_InfoChanged;
			Device.Battery.EnergySaverStatusChanged += Device_InfoChanged;
		}

		private void Device_InfoChanged(object sender, EventArgs e)
		{
			this.propertyGridInfo.Refresh(true);
		}

		private void DeviceInfo_Disposed(object sender, EventArgs e)
		{
			Device.Battery.BatteryInfoChanged -= Device_InfoChanged;
			Device.Networking.ConnectivityChanged -= Device_InfoChanged;
			Device.Display.MainDisplayInfoChanged -= Device_InfoChanged;
			Device.Battery.EnergySaverStatusChanged -= Device_InfoChanged;
		}
	}
}
