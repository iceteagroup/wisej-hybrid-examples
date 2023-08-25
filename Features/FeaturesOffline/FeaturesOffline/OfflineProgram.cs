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