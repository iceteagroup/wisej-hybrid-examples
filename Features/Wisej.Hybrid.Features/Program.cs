using System;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesOnline
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

		private static void Application_SessionTimeout(object sender, System.ComponentModel.HandledEventArgs e)
		{
			e.Handled = true;
		}

		private static void Application_ApplicationExit(object sender, EventArgs e)
		{
			Application.MainPage = new MainPage();
		}
	}
}