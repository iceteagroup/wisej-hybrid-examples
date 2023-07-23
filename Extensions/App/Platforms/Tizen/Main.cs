using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace App
{
	internal class Program : MauiApplication
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();

		static void Main(string[] args)
		{
			var app = new Program();
			app.Run(args);
		}
	}
}