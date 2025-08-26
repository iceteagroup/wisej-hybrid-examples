using Wisej.Hybrid;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.propertyGrid1.SelectedObject = Device.Networking;

			Device.Networking.ConnectivityChanged += Networking_ConnectivityChanged;
		}

		private void Networking_ConnectivityChanged(object sender, System.EventArgs e)
		{
			this.propertyGrid1.Refresh(true);

			AlertBox.Show($"Connected to internet: {Device.Networking.NetworkAccess == NetworkAccess.Internet}");
		}

		private void Page1_Disposed(object sender, System.EventArgs e)
		{
			Device.Networking.ConnectivityChanged -= Networking_ConnectivityChanged;
		}
	}
}
 