using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class Window : TestBase
	{
		public Window()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Device.Windows.Open("http://demo.wisej.com/CodeProject");
		}
	}
}
