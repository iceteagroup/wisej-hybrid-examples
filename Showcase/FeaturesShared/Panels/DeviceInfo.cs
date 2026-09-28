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

		public override void Activate()
		{
			this.propertyGridInfo.SelectedObject = new
			{
				System = Device.System,
				Battery = Device.Battery,
				Display = Device.Display,
				Networking = Device.Networking
			};
			this.propertyGridInfo.Refresh(true);

			Device.Battery.BatteryInfoChanged += Device_InfoChanged;
			Device.Networking.ConnectivityChanged += Device_InfoChanged;
			Device.Display.MainDisplayInfoChanged += Device_InfoChanged;
		}

		private void Device_InfoChanged(object sender, EventArgs e)
		{
			this.propertyGridInfo.Refresh(true);
		}

		public override void Deactivate()
		{
			Device.Battery.BatteryInfoChanged -= Device_InfoChanged;
			Device.Networking.ConnectivityChanged -= Device_InfoChanged;
			Device.Display.MainDisplayInfoChanged -= Device_InfoChanged;
		}
	}
}
