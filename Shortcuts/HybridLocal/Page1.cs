using System;
using Wisej.Hybrid;
using Wisej.Hybrid.Shared.AppActions;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			Device.Info.AppActions.AppActionChanged += AppActions_AppActionChanged;

			if (Device.Info.AppActions.Action != null)
				AlertBox.Show($"Startup action: {Device.Info.AppActions.Action.Title}");
		}

		private void AppActions_AppActionChanged(object sender, System.EventArgs e)
		{
			AlertBox.Show(Device.Info.AppActions.Action.Title);
		}

		private void buttonSet_Click(object sender, System.EventArgs e)
		{
			Device.AppActions.Set(new AppAction[] {
				new AppAction
				{
					Title = "Home"
				},
				new AppAction
				{
					Title = "Profile"
				},
				new AppAction
				{
					Title = "Settings"
				}
			});

			AlertBox.Show("Success");
		}

		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			Device.AppActions.Set(new AppAction[0]);
		}

		private void buttonGet_Click(object sender, System.EventArgs e)
		{
			AlertBox.Show(JSON.Stringify(Device.AppActions.Get()));
		}
	}
}
 