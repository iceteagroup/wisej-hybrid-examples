using HybridLocal.Services;
using Wisej.Web;

namespace HybridLocal
{
	internal static class Program
	{
		static Program()
		{
			Application.Services.AddService<UserService>((t) => new UserService(), Wisej.Services.ServiceLifetime.Session);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new MainPage();
		}
	}
}