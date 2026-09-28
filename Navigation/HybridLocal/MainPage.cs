using HybridLocal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace HybridLocal
{
	public partial class MainPage : Page
	{
		private readonly Stack<ViewBase> _views = new Stack<ViewBase>();

		private ViewBase CurrentView => _views.Count == 0 ? null : _views.Peek();

		// Both views must finish before reversing a transition.
		private bool IsNavigating => _views.Any(view => view.Busy);

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
			if (_views.Count <= 1 || IsNavigating)
				return;

			_views.Pop().PopDisappear();
			CurrentView.PopAppear();
		}

		// Pop views off the stack until the specified view type is found.
		private void PopToView(Type type)
		{
			var target = _views.FirstOrDefault(view => view.GetType() == type);
			if (target == null || target == CurrentView || IsNavigating)
				return;

			var outgoing = _views.Pop();
			while (CurrentView != target)
				_views.Pop().Dispose();

			outgoing.PopDisappear();
			target.PopAppear();
		}

		// Push a new view onto the stack.
		private void PushView(Type type)
		{
			if (IsNavigating)
				return;

			// Create a new instance of the requested view.
			var view = (ViewBase)Activator.CreateInstance(type);

			// Subscribe to view events.
			view.PushView += View_ViewRequested;
			view.PopToView += View_PopToView;
			view.PopView += View_PopView;

			// Configure the view.
			view.Dock = DockStyle.Fill;
			CurrentView?.PushDisappear();
			_views.Push(view);
			view.Parent = this;

			view.PushAppear();
		}

		private void View_PopToView(object sender, Type e)
		{
			if (sender == CurrentView)
				PopToView(e);
		}

		private void View_PopView(object sender, EventArgs e)
		{
			if (sender == CurrentView)
				PopView();
		}

		private void View_ViewRequested(object sender, Type e)
		{
			if (sender == CurrentView)
				PushView(e);
		}
	}
}
