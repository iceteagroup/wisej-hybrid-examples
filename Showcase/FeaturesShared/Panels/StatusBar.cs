using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.Shared.StatusBar;
using Wisej.Web;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
	public partial class StatusBar : TestBase
	{
		public StatusBar()
		{
			InitializeComponent();
		}

		private void StatusBar_Disappear(object sender, EventArgs e)
		{
			Device.StatusBar.BackColor = Color.FromName("@toolbar");
			Device.StatusBar.TextColor = Application.Theme.Name == "Bootstrap-4"
								? StatusBarTextColor.Black : StatusBarTextColor.White;
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
	}
}
