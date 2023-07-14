using System.ComponentModel;
using System.Drawing;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("UI")]
	public partial class TitleBar : TestBase
	{
		public TitleBar()
		{
			InitializeComponent();
		}

		private void buttonSetTitle_Click(object sender, System.EventArgs e)
		{
			Device.TitleBar.Text = this.textBoxTitle.Text;
		}

		private void textBoxBackColor_TextChanged(object sender, System.EventArgs e)
		{
			var color = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
			Device.TitleBar.BackgroundColor = color;
		}

		private void textBoxTextColor_TextChanged(object sender, System.EventArgs e)
		{
			var color = ColorTranslator.FromHtml(this.textBoxTextColor.Text);
			Device.TitleBar.TextColor = color;
		}

		private void Title_Load(object sender, System.EventArgs e)
		{
			var backColor = ColorTranslator.ToHtml(Device.TitleBar.BackgroundColor);
			this.textBoxBackColor.Text = backColor;

			var textColor = ColorTranslator.ToHtml(Device.TitleBar.TextColor);
			this.textBoxTextColor.Text = textColor;

			Device.TitleBar.Text = "Wisej.NET";
			this.textBoxTitle.Text = "Wisej.NET";

			this.checkBoxVisible.Checked = Device.TitleBar.Visible;
		}

		private void checkBoxVisible_CheckedChanged(object sender, System.EventArgs e)
		{
			Device.TitleBar.Visible = this.checkBoxVisible.Checked;
		}

		private void Title_Disposed(object sender, System.EventArgs e)
		{
			Device.TitleBar.Visible = false;
		}
	}
}
