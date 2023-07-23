using System.IO;
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
			var text = File.ReadAllText(Application.MapPath("checksum.txt"));

			Application.MainPage = new MainPage();
		}
	}
}