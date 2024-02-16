using Wisej.Hybrid;
using Wisej.Hybrid.Shared.Communication;
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
			this.propertyGrid1.SelectedObject = Device.Info.Networking;

			Device.Info.Networking.ConnectivityChanged += Networking_ConnectivityChanged;
		}

		private void Networking_ConnectivityChanged(object sender, System.EventArgs e)
		{
			this.propertyGrid1.Refresh(true);

			AlertBox.Show($"Connected to internet: {Device.Info.Networking.NetworkAccess == NetworkAccess.Internet}");
		}
	}
}
 