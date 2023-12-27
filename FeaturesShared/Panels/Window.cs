using System;
using System.ComponentModel;
using Wisej.Hybrid;

namespace FeaturesShared.Panels
{
	[Category("UI")]
	public partial class Window : Wisej.Hybrid.Features.TestBase
	{
		public Window()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Device.Windows.TryOpen("https://demo.wisej.com/Hybrid");
		}
	}
}
