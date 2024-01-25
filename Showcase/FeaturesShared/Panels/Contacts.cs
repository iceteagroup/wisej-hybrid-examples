using System;
using System.ComponentModel;
using Wisej.Hybrid.Modules.System;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Contacts : TestBase
	{
		public Contacts()
		{
			InitializeComponent();
		}

		private void buttonPickContact_Click(object sender, EventArgs e)
		{
			var result = Device.Contacts.Pick();
			AlertBox.Show(result.ToJSON());
		}

		private void buttonGetAllContacts_Click(object sender, EventArgs e)
		{
			var result = Device.Contacts.GetAll();
			AlertBox.Show(result.ToJSON());
		}

		public override bool IsSupported()
		{
			return Device.Valid && Device.Info.System.Platform != DevicePlatform.WinUI;
		}
	}
}
