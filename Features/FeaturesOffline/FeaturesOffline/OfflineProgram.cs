using System.IO;
using System.Linq;
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
			var f = Directory.GetFiles(Application.MapPath("Themes"), "*.*", SearchOption.AllDirectories);

			Application.MainPage = new MainPage();
		}
	}
}