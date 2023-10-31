using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Information")]
	public partial class AppInfo : TestBase
	{
		public AppInfo()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Device.AppInfo.ShowSettingsUI();
		}
	}
}
