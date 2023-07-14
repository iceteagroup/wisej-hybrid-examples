using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Toolbar : TestBase
	{
		public Toolbar()
		{
			InitializeComponent();
		}

		private void Toolbar_Load(object sender, EventArgs e)
		{
			Device.Toolbar.ItemClicked += Toolbar_ItemClicked;

			this.checkBoxVisible.Checked = Device.Toolbar.Visible;

			this.textBoxBackColor.Text = "#183C94";
			this.textBoxBackColor.Text = "#EDEDED";
			this.textBoxForeColor.Text = "#FFFFFF";

			UpdateItems();
		}

		private void Toolbar_ItemClicked(object sender, Shared.Toolbar.ToolbarItemClickedEventArgs e)
		{
			AlertBox.Show($"Selected {e.ToolbarItem.Text}");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			UpdateItems();
		}

		private void UpdateItems()
		{
			Device.Toolbar.Items =
				this.flowLayoutPanelItems.Controls
					.Where(c => c is BarButton && ((BarButton)c).Show)
						.Select(c => ((BarButton)c).ToToolbarItem()).ToArray();
		}

		private void backColor_TextChanged(object sender, EventArgs e)
		{
			Device.Toolbar.BackColor = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
		}

		private void foreColor_TextChanged(object sender, EventArgs e)
		{
			Device.Toolbar.ForeColor = ColorTranslator.FromHtml(this.textBoxForeColor.Text);
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
			Device.Toolbar.Visible = this.checkBoxVisible.Checked;
		}

		private void Toolbar_Disposed(object sender, EventArgs e)
		{
			Device.Toolbar.Visible = false;
			Device.Toolbar.ItemClicked -= Toolbar_ItemClicked;
		}
	}
}
