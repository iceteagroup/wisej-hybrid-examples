using HybridLocal.Views;
using System;
using System.Linq;
using System.Threading.Tasks;
using Wisej.Web;

namespace HybridLocal
{
	public partial class MainPage : Page
	{
		private ViewBase _currentView;

		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			// Show the initial view.
			PushView(typeof(LoginView));
		}

		// Pop the top view off the stack.
		private void PopView()
		{
			if (Controls.Count < 1)
				return;

			_currentView?.PopDisappear();
			_currentView = Controls.OfType<ViewBase>().LastOrDefault();
			_currentView?.PopAppear();
		}

		// Pop views off the stack until the specified view type is found.
		private void PopToView(Type type)
		{
			// continue popping until the specified view is found.
			while (_currentView.GetType() != type)
			{
				_currentView?.PopDisappear();
				_currentView = Controls.OfType<ViewBase>().LastOrDefault(c => !c.Busy);
			}

			_currentView?.PopAppear();
		}

		// Push a new view onto the stack.
		private void PushView(Type type)
		{
			if (_currentView != null && _currentView.Busy)
				return;

			_currentView?.PushDisappear();

			// Create a new instance of the requested view.
			var view = (ViewBase)Activator.CreateInstance(type);

			// Subscribe to view events.
			view.PushView += View_ViewRequested;
			view.PopToView += View_PopToView;
			view.PopView += View_PopView;

			// Configure the view.
			view.Dock = DockStyle.Fill;
			view.Parent = this;

			view.PushAppear();

			_currentView = view;
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
