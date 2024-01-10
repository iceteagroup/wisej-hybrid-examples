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
			var image = new MemoryStream(Device.Use<DeviceDocumentScanner>().Scan().FirstOrDefault());
			this.pictureBox1.Image = Image.FromStream(image);
		}
	}
}
 