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
			try
			{
				Device.Use<DeviceAuthentication>().Authenticate("Title", "Reason...");
				AlertBox.Show("Success!");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Message);
			}
		}

		private void Authentication_Load(object sender, EventArgs e)
		{
			var image = "";
			//switch (Device.Info.Use<DeviceInfo>.AuthenticationType)
			//{
			//	case AuthenticationType.None:
			//		image = "none-id.png";
			//		break;

			//	case AuthenticationType.TouchID:
			//		image = "touch-id.png";
			//		break;

			//	case AuthenticationType.FaceID:
			//		image = "face-id.png";
			//		break;

			//	case AuthenticationType.Passcode:
			//		image = "passcode.png";
			//		break;

			//	case AuthenticationType.UnknownBiometric:
			//		image = "unknown.png";
			//		break;

			//}

			//this.pictureBoxAuthenticate.ImageSource = $"Images/{image}";
		}
	}
}
