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

		private void buttonOn_Click(object sender, System.EventArgs e)
		{
			Device.Flashlight.TurnOn();
		}

		private void buttonOff_Click(object sender, System.EventArgs e)
		{
			Device.Flashlight.TurnOff();
		}
	}
}
