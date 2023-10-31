using System;
using System.Drawing;
using Wisej.Web;

namespace FeaturesShared.Windows
{
	public partial class ImageWindow : Form
	{
		public ImageWindow()
		{
			InitializeComponent();
		}

		public ImageWindow(Image image) : this()
		{
			this.pictureBox1.Image = image;
		}

		public ImageWindow(string imageSource) : this()
		{
			this.pictureBox1.ImageSource = imageSource;
		}
	}
}
