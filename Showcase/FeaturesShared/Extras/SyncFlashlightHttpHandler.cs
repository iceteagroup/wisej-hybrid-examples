using FeaturesShared.Panels;
using System;
using System.Linq;
using System.Web;

namespace FeaturesShared.Extras
{
	public class SyncFlashlightHttpHandler : IHttpHandler
	{
		bool IHttpHandler.IsReusable => true;

		void IHttpHandler.ProcessRequest(HttpContext context)
		{
			try
			{
				var queryString = context.Request.QueryString;
			
				Boolean.TryParse(queryString["on"], out bool on);

				string name = null;

				if (queryString.Keys.Count > 1)
				{
					name = queryString["name"];
				}

				SyncFlashlight.OnToggleFlash(name ?? "HTTP", on);

				context.Response.Write("OK");
			}
			catch (Exception ex)
			{
				context.Response.Write($"Failed: {ex.Message}");
			}
		}
	}
}
