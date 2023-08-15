using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("UI")]
	public partial class Background : TestBase
	{
		public Background()
		{
			InitializeComponent();
		}

		private void Background_Appear(object sender, EventArgs e)
		{
			var color = ColorNameToHex(Application.Theme.Colors["window"]);
			this.textBoxBackgroundColor.Text = color;
		}

		private void Background_Disappear(object sender, EventArgs e)
		{
			Device.Background.BackColor = Color.FromName("@window");
		}

		private void textBoxBackgroundColor_TextChanged(object sender, EventArgs e)
		{
			Device.Background.BackColor = ColorTranslator.FromHtml(this.textBoxBackgroundColor.Text);
		}

		private string ColorNameToHex(string colorName)
		{
			var color = Color.FromName(colorName);

			return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
		}
	}
}
