using HybridDatabase.Data;
using System;
using System.IO;
using Wisej.Hybrid;
using Wisej.Services;
using Wisej.Web;

namespace HybridOffline
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static Program()
		{
			// Register once, including when another browser session starts in this process.
			Application.Services.AddService<UserRepository>(CreateUserRepository, ServiceLifetime.Shared);
		}

		static void Main()
		{
			Application.MainPage = new MainPage();
		}

		private static UserRepository CreateUserRepository(Type serviceType)
		{
			var path = Path.Combine(Device.FileSystem.AppDataDirectory, "sampledatabase.sqlite");
			return new UserRepository(new DataContext(path));
		}
	}
}