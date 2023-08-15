using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace FeaturesShared.Windows
{
	public partial class VideoWindow : Form, IWisejHandler
	{
		private byte[] _video;

		public VideoWindow()
		{
			InitializeComponent();
		}

		public VideoWindow(byte[] video) : this()
		{
			this._video = video;

			this.video1.SourceURL = this.GetPostbackURL();
		}

		bool IWisejHandler.Compress => false;

		void IWisejHandler.ProcessRequest(HttpContext context)
		{
			context.Response.AppendHeader("Content-Disposition", "inline; filename=video.mp4");
			context.Response.AppendHeader("Content-Length", this._video.Length.ToString());
			context.Response.ContentType = "video/mp4";

			context.Response.BinaryWrite(this._video);
		}
	}
}
