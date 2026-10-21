using Wisej.Web;

namespace HybridLocal
{
	internal static class Program
	{
		static Program()
		{
			var apiUrl = System.Environment.GetEnvironmentVariable("HYBRID_REMOTE_API_URL")
				?? "https://8snsmzqh-5000.use.devtunnels.ms/";
			Application.Services.AddService<DataRepository>(new DataRepository(apiUrl));
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new Page1();
		}
	}
}