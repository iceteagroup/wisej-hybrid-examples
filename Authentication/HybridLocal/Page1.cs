using Wisej.Hybrid;
using Wisej.Hybrid.Authentication;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			var result = Device.Use<DeviceAuthentication>().Authenticate("Authenticate", "Authenticate User");

			AlertBox.Show(result.ToString());
		}
	}
}
