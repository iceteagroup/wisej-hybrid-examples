﻿using System;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class NewTab : TestBase
	{
		public NewTab()
		{
			InitializeComponent();
		}

		private void buttonNewTab_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://wisej.com", "_blank");
		}

		private void buttonNewTabMailTo_Click(object sender, EventArgs e)
		{
			Application.Navigate("mailto:info@acme.com", "_blank");
		}
	}
}
