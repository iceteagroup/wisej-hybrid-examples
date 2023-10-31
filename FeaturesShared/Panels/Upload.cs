using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Media")]
	public partial class UploadMedia : TestBase
	{
		public UploadMedia()
		{
			InitializeComponent();
		}

		private void upload1_Uploaded(object sender, UploadedEventArgs e)
		{
			AlertBox.Show($"Upload: {e.Files[0].ContentLength} bytes");
		}
	}
}
