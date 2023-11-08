using System;
using System.ComponentModel;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesOffline
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.SessionTimeout += Application_SessionTimeout;
			Application.ApplicationExit += Application_ApplicationExit;

			//string s1 = "";
			//string s2 = "/////\n";
			//string s3 = "/////\r\n";

			//var pos1 = s1.IndexOf('.');
			//var pos2 = s2.IndexOf('\n');

			//var sw = s1.StartsWith(".");
			//var sw2 = s1.StartsWith("[]");

			//decimal d = 4.5m;

			Application.MainPage = new MainPage();
		}

		private static void Application_ApplicationExit(object sender, EventArgs e)
		{
			Application.MainPage = new MainPage();
		}

		private static void Application_SessionTimeout(object sender, HandledEventArgs e)
		{
			e.Handled = true;
		}
	}
}