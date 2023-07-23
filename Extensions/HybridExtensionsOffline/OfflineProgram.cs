﻿using ExtensionsShared;
using System;
using Wisej.Hybrid;
using Wisej.Web;

namespace HybridExtensionsOffline
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new MainPage();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}