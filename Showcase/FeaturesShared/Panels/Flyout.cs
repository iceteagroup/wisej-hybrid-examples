using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Hybrid.Shared.Flyout;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class Flyout : TestBase
	{
		public Flyout()
		{
			InitializeComponent();
		}

		private void Flyout_Appear(object sender, EventArgs e)
		{
			Device.Flyout.ItemSelected += Flyout_ItemSelected;

			Device.Flyout.Behavior = FlyoutBehavior.Flyout;
			this.textBoxBackgroundColor.Text = Application.Theme.Colors.toolbar;

			Device.Flyout.Items = new[]
			{
				new FlyoutItem {
					Title = "Home",
					ImageSource = "resource.wx/FeaturesShared/Images/Icons/Home.png"
				},
				new FlyoutItem {
					Title = "Edit",
					ImageSource = "resource.wx/FeaturesShared/Images/Icons/Edit.png"
				},
				new FlyoutItem {
					Title = "Settings",
					ImageSource = "resource.wx/FeaturesShared/Images/Icons/Settings.png"
				},
				new FlyoutItem {
					Title = "More",
					ImageSource = "resource.wx/FeaturesShared/Images/Icons/More.png"
				}
			};
		}

		private void Flyout_Disappear(object sender, EventArgs e)
		{
			Device.Flyout.Behavior = FlyoutBehavior.Disabled;
			Device.Flyout.ItemSelected -= Flyout_ItemSelected;
		}

		private void Flyout_ItemSelected(object sender, FlyoutItemSelectedEventArgs e)
		{
			AlertBox.Show($"Selected {e.Item.Title}");
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			Device.Flyout.Behavior = this.checkBoxVisible.Checked ? FlyoutBehavior.Flyout : FlyoutBehavior.Disabled;
		}

		private void textBoxBackgroundColor_TextChanged(object sender, EventArgs e)
		{
			var color = this.textBoxBackgroundColor.Text;
			Device.Flyout.BackgroundColor = ColorTranslator.FromHtml(color);
		}
	}
}
