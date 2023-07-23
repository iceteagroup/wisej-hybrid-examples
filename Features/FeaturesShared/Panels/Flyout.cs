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

			Device.Flyout.ItemSelected += Flyout_ItemSelected;
		}

		private void Flyout_Load(object sender, EventArgs e)
		{
			this.checkBoxVisible.Checked = Device.Flyout.Behavior == FlyoutBehavior.Flyout;
			this.textBoxBackgroundColor.Text = ColorTranslator.ToHtml(Device.Flyout.BackgroundColor);
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

		private void button1_Click(object sender, EventArgs e)
		{
			

			Device.Flyout.Items = new[]
			{
				new FlyoutItem { 
					Title = "Home",
					ImageSource = $"{Ext.MaterialDesign.Icons.HomeButton}?color=white"
				},
				new FlyoutItem {
					Title = "Profile",
					ImageSource = $"{Ext.MaterialDesign.Icons.UserAccountBox}?color=white"
				},
				new FlyoutItem { 
					Title = "Messages",
					ImageSource = $"{Ext.MaterialDesign.Icons.GmailLogo}?color=white"
				},
				new FlyoutItem { 
					Title = "Settings",
					ImageSource = $"{Ext.MaterialDesign.Icons.PhoneSettings}?color=white"
				}
			};
		}

		private void Flyout_Disposed(object sender, EventArgs e)
		{
			Device.Flyout.ItemSelected -= Flyout_ItemSelected;
		}
	}
}
