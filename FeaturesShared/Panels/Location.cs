using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Location : TestBase
	{
		public Location()
		{
			InitializeComponent();
		}

		private async void buttonGetLocation_Click(object sender, EventArgs e)
		{
			if (this.checkBoxUseNativeLocationServices.Checked)
			{
				try
				{
					var position = Device.Geolocation.GetLocation();
					
					this.propertyGrid1.SelectedObject = position;
				}
				catch (DeviceException ex)
				{
					AlertBox.Show(ex.Message);
				}
			}
			else
			{
				// use browser geolocation integration.
				var position = await this.geolocation1.GetCurrentPositionAsync();

				this.propertyGrid1.SelectedObject = position;
			}
		}
	}
}
