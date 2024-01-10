using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Wisej.Hybrid.Shared.TabBar;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class TabBar : TestBase
	{
		public TabBar()
		{
			InitializeComponent();
		}

		private void TabBar_Appear(object sender, EventArgs e)
		{
			Device.TabBar.TabSelected -= this.TabBar_TabSelected;

			Device.TabBar.Visible = this.checkBoxVisible.Checked;

			SetThemeColors();
			UpdateTabs();

			Device.TabBar.TabSelected += this.TabBar_TabSelected;

			Application.ThemeChanged += Application_ThemeChanged;
		}

		private void TabBar_Disappear(object sender, EventArgs e)
		{
			Application.ThemeChanged -= Application_ThemeChanged;
			Device.TabBar.TabSelected -= this.TabBar_TabSelected;

			Device.TabBar.Visible = false;
		}

		private void Application_ThemeChanged(object sender, EventArgs e)
		{
			SetThemeColors();
		}

		private void SetThemeColors()
		{
			var name = Application.Theme.Name;
			var backColor = name == "Bootstrap-4" ? "#F6F8FA" : "#383940";
	
			this.textBoxBackColor.Text = backColor;
			this.textBoxUnselectedColor.Text = "#B0B0B0";
			this.textBoxSelectedColor.Text = Application.Theme.Colors.primary;
		}

		private void TabBar_TabSelected(object sender, TabSelectedEventArgs e)
		{
			AlertBox.Show($"Selected {e.SelectedTabBarItem.Title}");
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			UpdateColors();

			Device.TabBar.Visible = this.checkBoxVisible.Checked;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			UpdateTabs();
		}

		private void UpdateTabs()
		{
			var items = 
				this.flowLayoutPanelItems.Controls
					.Where(c => c is BarButton && ((BarButton)c).Show)
						.Select(c => ((BarButton)c).ToTabBarItem()).ToArray();

			var item = items.FirstOrDefault();
			if (item != null)
			{
				item.Selected = true;
				item.Badge = 5;
			}

			Device.TabBar.Items = items;
		}

		private void textBoxBackColor_TextChanged(object sender, EventArgs e)
		{
			UpdateColors();
		}

		private void textBoxUnselectedColor_TextChanged(object sender, EventArgs e)
		{
			UpdateColors();
		}

		private void textBoxSelectedColor_TextChanged(object sender, EventArgs e)
		{
			UpdateColors();
		}

		private void UpdateColors()
		{
			// apply background color.
			var color = ColorTranslator.FromHtml(this.textBoxBackColor.Text);

			Device.TabBar.BackColor = color;

			// apply unselected color.
			Device.TabBar.UnselectedColor = ColorTranslator.FromHtml(this.textBoxUnselectedColor.Text);

			// apply selected color.
			Device.TabBar.SelectedColor = ColorTranslator.FromHtml(this.textBoxSelectedColor.Text);

			var visible = this.checkBoxVisible.Checked;
			if (visible)
				Device.BottomBar.BackColor = color;
			else
				Device.BottomBar.BackColor = ColorTranslator.FromHtml(Application.Theme.Colors.window);
		}
	}
}
