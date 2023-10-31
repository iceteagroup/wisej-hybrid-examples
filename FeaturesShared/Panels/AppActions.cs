using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.Shared.AppActions;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Information")]
	public partial class AppActions : TestBase
	{
		public AppActions()
		{
			InitializeComponent();
		}

		private void buttonSetShortcuts_Click(object sender, EventArgs e)
		{
			// app shortcuts.
			Device.AppActions.Set(new AppAction[]
			{
				new AppAction { Id = "Action1", Title = this.textBoxShorcut1.Text },
				new AppAction { Id = "Action2", Title = this.textBoxShortcut2.Text },
				new AppAction { Id = "Action3", Title = this.textBoxShortcut3.Text }
			});
		}
	}
}
