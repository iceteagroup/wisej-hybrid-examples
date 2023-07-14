using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.Shared.StatusBar;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
	public partial class StatusBar : TestBase
	{
		public StatusBar()
		{
			InitializeComponent();
		}

		private void checkBoxVisible_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void textBoxBackColor_TextChanged(object sender, EventArgs e)
		{
			Device.StatusBar.BackColor = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
		}

		private void comboBoxTextColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			var color = (string) comboBoxTextColor.SelectedItem;
			Device.StatusBar.TextColor = (StatusBarTextColor) Enum.Parse(typeof(StatusBarTextColor), color);
		}

		private void StatusBar_Disposed(object sender, EventArgs e)
		{
			Device.StatusBar.TextColor = StatusBarTextColor.Black;
			Device.StatusBar.BackColor = Color.FromArgb(253, 253, 253);
		}
	}
}
