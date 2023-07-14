using System;
using System.ComponentModel;
using Wisej.Hybrid.CommunityToolkit;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Alerts")]
	public partial class Toast : TestBase
	{
		public Toast()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Device.Use<DeviceToast>().Show(this.textBox1.Text, ToastDuration.Short, 14);
		}
	}
}
