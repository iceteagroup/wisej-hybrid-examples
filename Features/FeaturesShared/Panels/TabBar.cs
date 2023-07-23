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

		private void TabBar_Load(object sender, EventArgs e)
		{
			Device.TabBar.TabSelected += this.TabBar_TabSelected;

			this.checkBoxVisible.Checked = Device.TabBar.Visible;

			SetThemeColors();
			UpdateTabs();

			Application.ThemeChanged += Application_ThemeChanged;
		}

		private void Application_ThemeChanged(object sender, EventArgs e)
		{
			SetThemeColors();
		}

		private void SetThemeColors()
		{
			var name = Application.Theme.Name;
			var backColor = name == "Bootstrap-4" ? "#F6F8FA" : "#383940";

			// schedule change as last task.
			Application.StartTask(() =>
			{
				Device.BottomBar.BackColor = ColorTranslator.FromHtml(backColor);
			});
	
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
			var visible = this.checkBoxVisible.Checked;
			if (visible)
				Device.BottomBar.BackColor = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
			else
				Device.BottomBar.BackColor = Color.White;

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

			items[0].Selected = true;

			Device.TabBar.Items = items;
		}

		private void backColor_TextChanged(object sender, EventArgs e)
		{
			var color = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
			var visible = this.checkBoxVisible.Checked;
			if (visible)
				Device.BottomBar.BackColor = color;
			else
				Device.BottomBar.BackColor = ColorTranslator.FromHtml(Application.Theme.Colors.window);

			Device.TabBar.BackColor = color;
		}

		private void color_TextChanged(object sender, EventArgs e)
		{
			Device.TabBar.UnselectedColor = ColorTranslator.FromHtml(this.textBoxSelectedColor.Text);
		}

		private void selectedColor_TextChanged(object sender, EventArgs e)
		{
			Device.TabBar.SelectedColor = ColorTranslator.FromHtml(this.textBoxUnselectedColor.Text);
		}

		private void TabBar_Disposed(object sender, EventArgs e)
		{
			Application.ThemeChanged -= Application_ThemeChanged;

			Device.TabBar.Visible = false;
			Device.BottomBar.BackColor = Color.White;
			Device.TabBar.TabSelected -= TabBar_TabSelected;
		}
	}
}
