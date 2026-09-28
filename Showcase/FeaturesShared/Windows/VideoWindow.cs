using System;
using System.Globalization;
using Wisej.Core;
using Wisej.Web;

namespace FeaturesShared.Windows
{
	public partial class VideoWindow : Form, IWisejHandler
	{
		private byte[] _video = Array.Empty<byte>();

		public VideoWindow()
		{
			InitializeComponent();
			this.Disposed += (_, _) => this._video = Array.Empty<byte>();
		}

		public VideoWindow(byte[] video) : this()
		{
			this._video = video ?? throw new ArgumentNullException(nameof(video));

			this.video1.SourceURL = this.GetPostbackURL();
		}

		bool IWisejHandler.Compress => false;

		void IWisejHandler.ProcessRequest(HttpContext context)
		{
			var video = this._video;
			var response = context.Response;
			var head = string.Equals(context.Request.RequestType, "HEAD", StringComparison.OrdinalIgnoreCase);
			if (!head && !string.Equals(context.Request.RequestType, "GET", StringComparison.OrdinalIgnoreCase))
			{
				response.StatusCode = 405;
				response.AppendHeader("Allow", "GET, HEAD");
				return;
			}
			if (video.Length == 0)
			{
				response.StatusCode = 404;
				return;
			}

			// Safari/WKWebView probes byte ranges before starting playback and when seeking.
			// A range applies only to GET; HEAD returns the full representation's headers.
			var range = VideoByteRange.Parse(head ? null : context.Request.Headers["Range"], video.Length);
			response.StatusCode = range.StatusCode;
			response.AppendHeader("Accept-Ranges", "bytes");
			response.AppendHeader("Cache-Control", "private, no-store");
			context.Response.AppendHeader("Content-Disposition", "inline; filename=video.mp4");
			response.AppendHeader("Content-Length", range.Count.ToString(CultureInfo.InvariantCulture));
			response.ContentType = "video/mp4";
			if (range.StatusCode == 416)
			{
				response.AppendHeader("Content-Range", $"bytes */{video.Length}");
				return;
			}
			if (range.StatusCode == 206)
				response.AppendHeader("Content-Range", $"bytes {range.Offset}-{range.Offset + range.Count - 1}/{video.Length}");

			if (!head)
				response.BinaryWrite(video, range.Offset, range.Count);
		}
	}
}
