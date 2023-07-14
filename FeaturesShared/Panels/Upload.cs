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

			new Wisej.Web.Upload();
		}
	}
}
