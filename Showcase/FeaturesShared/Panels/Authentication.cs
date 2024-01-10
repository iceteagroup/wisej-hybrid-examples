using System;
using System.ComponentModel;
using Wisej.Hybrid.Authentication;
using Wisej.Web;

namespace Wisej.Hybrid.Features
{
	[Category("Security")]
	public partial class Authentication : TestBase
	{
		public Authentication()
		{
			InitializeComponent();
		}

		private void buttonAuthenticate_Click(object sender, EventArgs e)
		{
			var result = Device.Use<DeviceAuthentication>().Authenticate("Authenticate", "Reason...");
			AlertBox.Show($"Result: {result}");
		}
	}
}
