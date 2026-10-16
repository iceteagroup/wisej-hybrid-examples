using EmbedIO;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Wisej.EmbedIO;

namespace FeaturesOffline
{
	public class OfflineStartup
	{
		public static string Main(CancellationToken token, object[] args)
		{
			token.ThrowIfCancellationRequested();
			// Each app instance needs its own loopback port, including simulators.
			using var listener = new TcpListener(IPAddress.Loopback, 0);
			listener.Start();
			var url = $"http://localhost:{((IPEndPoint)listener.LocalEndpoint).Port}";
			listener.Stop();
			var server = new WebServer(url);
			var running = RunAsync(server, token);
			// RunAsync binds before its first await. Surface startup failures to Hybrid.
			if (running.IsCompleted)
				running.GetAwaiter().GetResult();
			token.ThrowIfCancellationRequested();
			_ = running.ContinueWith(task => Trace.TraceError(task.Exception.ToString()),
				CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);

			return url + "/Offline.html";
		}

		private static async Task RunAsync(WebServer server, CancellationToken token)
		{
			using (server)
			{
				server.WithWisej();
				await server.RunAsync(token).ConfigureAwait(false);
			}
		}
	}
}
