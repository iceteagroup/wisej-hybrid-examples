using HybridLocal.Views;
using System;
using System.Linq;
using Wisej.Web;

namespace HybridLocal
{
	public partial class MainPage : Page
	{
		// the current displayed view.
		private ViewBase _currentView;

		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			PushView(typeof(LoginView));
		}

		private void PopView()
		{
			this._currentView?.PopDisappear();

			this._currentView = (ViewBase)this.Controls.LastOrDefault();
			this._currentView?.PopAppear();
		}

		private void PopToView(Type type)
		{
			this._currentView?.PopDisappear();

			var view = this.Controls.LastOrDefault(c => type == c.GetType());

			if (view is ViewBase lastView)
			{
				this._currentView = lastView;
				this._currentView.PopAppear();
			}
		}

		private void PushView(Type type)
		{
			this._currentView?.PushDisappear();

			// create a new instance of the requested view (or implement re-use).
			var view = (ViewBase)Activator.CreateInstance(type);

			// allow this view to request other views.
			view.PushView += View_ViewRequested;
			view.PopToView += View_PopToView;
			view.PopView += View_PopView;

			// configure the view.
			view.Dock = DockStyle.Fill;
			view.Parent = this;

			view.PushAppear();

			this._currentView = view;
		}

		private void View_PopToView(object sender, Type e)
		{
			PopToView(e);
		}

		private void View_PopView(object sender, EventArgs e)
		{
			PopView();
		}

		private void View_ViewRequested(object sender, Type e)
		{
			PushView(e);
		}
	}
}