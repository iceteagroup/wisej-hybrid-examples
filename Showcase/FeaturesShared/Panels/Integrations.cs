using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

		internal Task Initialize()
		{
			// calculate item width.
			if (Application.Browser.Device == "Mobile")
			{
				var screenSize = Application.Browser.ScreenSize;
				var screenWidth = Math.Min(screenSize.Width, screenSize.Height);

				this._itemWidth = (screenWidth - 32) / 2 - 20;
			}
			else
			{
				this._itemWidth = 225;
			}

			return Application.StartTask(() =>
			{
				var asm = GetType().Assembly;
				var excludedTypes = new List<Type> { typeof(TestBase), typeof(Integrations) };

				var apps = asm.GetTypes()
					.Where(t => !excludedTypes.Contains(t) && typeof(TestBase).IsAssignableFrom(t))
					.OrderBy(t => t.Name)
					.Select(CreateAppItemView)
					.ToArray();

				// add apps to panel.
				this.flowLayoutPanelApps.Controls.AddRange(apps);

				Application.Update(this);
			});
		}

		private AppItemView CreateAppItemView(Type t)
		{
			var view = new AppItemView((TestBase)Activator.CreateInstance(t)) { Width = this._itemWidth };
			view.ViewRequested += Integrations_ViewRequested;
			return view;
		}

		private void Integrations_ViewRequested(object sender, WidgetEventArgs e)
		{
			this.OnViewRequested(e);
		}

		private void flowLayoutPanelApps_Scroll(object sender, ScrollEventArgs e)
		{
			this._scrollValue = e.NewValue;

			var scrollDown = e.NewValue - e.OldValue > 0;

			if (e.NewValue == 0)
				this.MaximizeTitle();
			else if (scrollDown)
				this.MinimizeTitle();
		}
		private int _scrollValue = 0;

		private void Integrations_Appear(object sender, EventArgs e)
		{
			// workaround. something is causiing the panel to not restore it's scroll position when appearing.
			this.flowLayoutPanelApps.VerticalScroll.Value = 0;
			Application.Update(this);
			this.flowLayoutPanelApps.VerticalScroll.Value = this._scrollValue;
		}
	}
}
