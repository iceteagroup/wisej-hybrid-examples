using System;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	public partial class PullToRefreshItem : Wisej.Web.UserControl
	{
		public PullToRefreshItem()
		{
			InitializeComponent();
		}

		public PullToRefreshItem(string imageSource) : this()
		{
			this.pictureBox1.ImageSource = imageSource;
		}
	}
}
