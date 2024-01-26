using HybridLocal.Views;
using System;
using Wisej.Web;

namespace HybridLocal
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			LoadView(typeof(LoginView));
		}

		private void LoadView(Type type)
		{
			this.Controls.Clear();

			// create a new instance of the requested view (or implement re-use).
			var view = (ViewBase)Activator.CreateInstance(type);

			// inject application services into the view.
			Application.Services.Inject(view);

			// allow this view to request other views.
			view.ViewRequested += View_ViewRequested;

			// configure the view.
			view.Dock = DockStyle.Fill;
			view.Parent = this;
		}

		private void View_ViewRequested(object sender, Type e)
		{
			LoadView(e);
		}
	}
}