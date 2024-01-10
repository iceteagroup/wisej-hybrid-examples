using System;
using System.ComponentModel;
using Wisej.Hybrid.Shared.Permissions;
using Wisej.Web;

namespace Wisej.Hybrid.Features
{
	[Category("Permissions")]
	public partial class Permissions : TestBase
	{
		public Permissions()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			try
			{
				var permission = (PermissionType)Enum.Parse(typeof(PermissionType), button.Text);
				var result = Device.Permissions.Request(permission);
				AlertBox.Show($"{permission}: {result}");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Message);
			}
		}
	}
}
