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

		private void Authentication_Load(object sender, EventArgs e)
		{
			var info = Device.Info.Use<DeviceAuthenticationInfo>();

			switch (info.AuthenticationType)
			{
				case AuthenticationType.TouchId:
					this.pictureBoxAuthenticate.ImageSource = "resource.wx/FeaturesShared/Images/touch-id.png";
					break;

				case AuthenticationType.Passcode:
					this.pictureBoxAuthenticate.ImageSource = "resource.wx/FeaturesShared/Images/passcode.png";
					break;

				case AuthenticationType.Unknown:
					this.pictureBoxAuthenticate.ImageSource = "resource.wx/FeaturesShared/Images/unknown.png";
					break;
			}
		}

		private void buttonAuthenticate_Click(object sender, EventArgs e)
		{
			var result = Device.Use<DeviceAuthentication>().Authenticate("Authenticate", "Reason...");
			AlertBox.Show($"Result: {result}");
		}
	}
}
