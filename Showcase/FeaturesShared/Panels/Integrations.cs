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
			this.flowLayoutPanelApps.SizeChanged += (_, _) => UpdateItemWidths();
		}

		private bool _initialized;

		internal Task Initialize()
		{
			if (this._initialized)
				return Task.CompletedTask;

			this.flowLayoutPanelApps.SuspendLayout();
			try
			{
				var asm = GetType().Assembly;
				var excludedTypes = new List<Type> { typeof(TestBase), typeof(Integrations) };

				var apps = asm.GetTypes()
					.Where(t => !t.IsAbstract && !excludedTypes.Contains(t) && typeof(TestBase).IsAssignableFrom(t))
					.OrderBy(t => t.Name)
					.Select(CreateAppItemView)
					.ToArray();

				// add apps to panel.
				this.flowLayoutPanelApps.Controls.AddRange(apps);
				UpdateItemWidths();
				this._initialized = true;
			}
			finally
			{
				this.flowLayoutPanelApps.ResumeLayout(true);
			}
			return Task.CompletedTask;
		}

		private AppItem CreateAppItemView(Type t)
		{
			var view = new AppItem(t);
			view.ViewRequested += Integrations_ViewRequested;
			return view;
		}

		private void UpdateItemWidths()
		{
			var availableWidth = this.flowLayoutPanelApps.ClientSize.Width - this.flowLayoutPanelApps.Padding.Horizontal;
			if (availableWidth <= 0)
				return;

			// Keep cards readable on phones and use the panel's current width after rotation/resizing.
			const int margin = 20;
			var columns = Math.Max(1, availableWidth / (160 + margin));
			var width = Math.Max(1, Math.Min(225, availableWidth / columns - margin));
			foreach (AppItem item in this.flowLayoutPanelApps.Controls)
				item.Width = width;
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
