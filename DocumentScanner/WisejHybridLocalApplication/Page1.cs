using System.Drawing;
using System.IO;
using System.Linq;
using Wisej.Hybrid;
using Wisej.Hybrid.DocumentScanner;
using Wisej.Web;

namespace WisejHybridLocalApplication
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.pictureBox1.Image = Device.Use<DeviceDocumentScanner>().Scan(1280, 720).FirstOrDefault();
		}
	}
}
 