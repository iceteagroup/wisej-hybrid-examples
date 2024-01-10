﻿using FeaturesShared.Windows;
using System;
using System.ComponentModel;
using Wisej.Hybrid.DocumentScanner;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Hardware")]
	public partial class DocumentScanner : TestBase
	{
		private BindingSource data = new BindingSource();

		public DocumentScanner()
		{
			InitializeComponent();
		}

		private void buttonScan_Click(object sender, EventArgs e)
		{
			try
			{
				var size = 0L;
				var scanner = Device.Use<DeviceDocumentScanner>();

				var imageScaleFactor = (float)this.trackBarQuality.Value / 10;
				foreach (dynamic image in scanner.Scan(imageScaleFactor)) 
				{
					new ImageWindow(image).Show();
				}

				AlertBox.Show($"Size of uploaded images: {size} bytes");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Message);
			}
		}

		public override bool IsSupported()
		{
			return Device.Info.System.Platform == "iOS" || Device.Info.System.Platform == "Android";
		}
	}
}