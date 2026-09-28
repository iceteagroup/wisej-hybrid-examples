using FeaturesShared.Windows;
using Wisej.Core;

var video = Enumerable.Range(0, 100).Select(x => (byte)x).ToArray();
var window = new VideoWindow(video);
var handler = (IWisejHandler)window;
var checks = 0;

void Check(string method, string header, int status, int offset, int count, string contentRange = null)
{
	var context = new HttpContext();
	context.Request.RequestType = method;
	if (header != null) context.Request.Headers["Range"] = header;
	handler.ProcessRequest(context);
	var response = context.Response;
	if (response.StatusCode != status || response.Headers["Content-Range"] != contentRange)
		throw new Exception($"Unexpected status/range for {method} {header}: {response.StatusCode}, {response.Headers["Content-Range"]}");
	if (status == 200 || status == 206 || status == 416)
	{
		if (response.Headers["Accept-Ranges"] != "bytes" || response.Headers["Content-Length"] != count.ToString())
			throw new Exception($"Unexpected length/accept-ranges for {method} {header}");
	}
	var expected = method == "GET" && (status == 200 || status == 206)
		? video.Skip(offset).Take(count).ToArray() : Array.Empty<byte>();
	if (!response.Body.ToArray().SequenceEqual(expected))
		throw new Exception($"Unexpected payload for {method} {header}");
	checks++;
}

Check("GET", null, 200, 0, 100);
Check("GET", "bytes=0-1", 206, 0, 2, "bytes 0-1/100"); // WKWebView probe.
Check("GET", "bytes=25-", 206, 25, 75, "bytes 25-99/100");
Check("GET", "bytes=-10", 206, 90, 10, "bytes 90-99/100");
Check("GET", "bytes=-200", 206, 0, 100, "bytes 0-99/100");
Check("GET", "bytes=99-1000", 206, 99, 1, "bytes 99-99/100");
Check("GET", "BYTES= 1-2 ", 206, 1, 2, "bytes 1-2/100");
foreach (var invalid in new[] { "bytes=100-", "bytes=10-5", "bytes=-0", "bytes=-", "bytes=abc-5", "bytes=1--2", "bytes=9223372036854775808-" })
	Check("GET", invalid, 416, 0, 0, "bytes */100");
Check("GET", "bytes=0-1,5-9", 200, 0, 100);
Check("GET", "items=0-1", 200, 0, 100);
Check("HEAD", "bytes=0-1", 200, 0, 100);
Check("HEAD", "bytes=100-", 200, 0, 100);
Check("POST", null, 405, 0, 0);
window.Dispose();
Check("GET", null, 404, 0, 0);
if (VideoByteRange.Parse("bytes=0-", 0).StatusCode != 416)
	throw new Exception("Empty representation must not have a satisfiable range.");
Console.WriteLine($"PASS: {checks} video HTTP responses, plus empty-range validation.");

// Minimal transport/control adapters let the actual handler execute without a browser session.
// Full Showcase builds separately verify these calls against the real Wisej API.
namespace Wisej.Core
{
	public interface IWisejHandler
	{
		bool Compress { get; }
		void ProcessRequest(HttpContext context);
	}
	public class HttpContext
	{
		public HttpRequest Request { get; } = new();
		public HttpResponse Response { get; } = new();
	}
	public class HttpRequest
	{
		public string RequestType { get; set; }
		public System.Collections.Specialized.NameValueCollection Headers { get; } = new();
	}
	public class HttpResponse
	{
		public int StatusCode { get; set; } = 200;
		public string ContentType { get; set; }
		public System.Collections.Specialized.NameValueCollection Headers { get; } = new();
		public MemoryStream Body { get; } = new();
		public void AppendHeader(string name, string value) => Headers[name] = value;
		public void BinaryWrite(byte[] value, int offset, int count) => Body.Write(value, offset, count);
	}
}
namespace Wisej.Web
{
	public class Form : IDisposable
	{
		public event EventHandler Disposed;
		public string GetPostbackURL() => "/video";
		public void Dispose() => Disposed?.Invoke(this, EventArgs.Empty);
	}
	public class Video { public string SourceURL { get; set; } }
}
namespace FeaturesShared.Windows
{
	public partial class VideoWindow
	{
		private Wisej.Web.Video video1;
		private void InitializeComponent() => video1 = new();
	}
}
