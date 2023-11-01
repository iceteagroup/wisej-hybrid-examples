using System;
using System.ComponentModel;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("UI")]
	public partial class PullToRefresh : TestBase
	{
		private int _itemWidth = 0;
		private Random _rand = new Random();
		private Wisej.Web.Ext.PullToRefresh.PullToRefresh pullToRefresh = new Wisej.Web.Ext.PullToRefresh.PullToRefresh();

		public PullToRefresh()
		{
			InitializeComponent();

			pullToRefresh.SetPullToRefresh(this.flowLayoutPanelData, true);
			pullToRefresh.ImageSource = "resource.wx/loader.svg";
			pullToRefresh.Refresh += Ptr_Refresh;
		}

		private void PullToRefresh_Load(object sender, EventArgs e)
		{
			// ScreenSize is different on Android vs. iOS.
			if (Application.Browser.Device == "Mobile")
			{
				var screenSize = Application.Browser.ScreenSize;
				var screenWidth = Math.Min(screenSize.Width, screenSize.Height);

				this._itemWidth = (screenWidth - 32) / 2 - 20;
			}
			else
			{
				this._itemWidth = (this.Width - 48) / 3 - 20;
			}

			RefreshData();
		}

		private void Ptr_Refresh(object? sender, EventArgs e)
		{
			RefreshData();
		}

		private void RefreshData()
		{
			this.flowLayoutPanelData.Controls.Clear();

			for (var i = 0; i < _rand.Next(20, 50); i++)
			{
				var imageSource = $"https://randomuser.me/api/portraits/men/{_rand.Next(50)}.jpg";
				var b = new PullToRefreshItem(imageSource)
				{
					Width = this._itemWidth,
					Height = this._itemWidth
				};

				this.flowLayoutPanelData.Controls.Add(b);
			}
		}
	}
}
