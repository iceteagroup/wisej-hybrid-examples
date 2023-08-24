using EmbedIO;
using System.IO;
using System.Threading;
using Wisej.EmbedIO;

namespace FeaturesOffline
{
	public class OfflineStartup
	{
		public static string Main(CancellationToken token, object[] args)
		{
			var url = "http://localhost:5000";
			var server = new WebServer(url);
			server.WithWisej();
			server.WithStaticFolder("/", Path.GetDirectoryName(typeof(OfflineStartup).Assembly.Location), true);

			new Thread(() => server.RunAsync(token).Wait()).Start();

			return url;
		}
	}
}