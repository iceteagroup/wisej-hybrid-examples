using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	public partial class Integrations : TestBase
	{
		public Integrations()
		{
			InitializeComponent();
		}

		private int _itemWidth;

		private void Integrations_Load(object sender, EventArgs e)
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

			LoadApps();
		}

		private void LoadApps()
		{
			var asm = GetType().Assembly;
			var apps = asm.GetTypes()
				.Where(t => t != typeof(TestBase) && t != typeof(Integrations) && typeof(TestBase).IsAssignableFrom(t))
				.OrderBy(t => t.Name)
				.Select(t => {
					var view = new AppItemView((TestBase)Activator.CreateInstance(t)) { Width = this._itemWidth };
					view.ViewRequested += Integrations_ViewRequested;
					return view;
					})
				.ToArray();

			this.flowLayoutPanelApps.Controls.AddRange(apps);
		}

		private void Integrations_ViewRequested(object sender, WidgetEventArgs e)
		{
			this.OnViewRequested(e);
		}

		private void flowLayoutPanelApps_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue == 0)
				this.MaximizeTitle();
			else
				this.MinimizeTitle();
		}
	}
}
