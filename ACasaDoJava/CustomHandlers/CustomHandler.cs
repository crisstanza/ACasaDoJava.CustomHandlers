using System;
using System.Web;

namespace ACasaDoJava.CustomHandlers
{
	public class CustomHandler : IHttpHandler
	{
		
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";
			string output = System.IO.File.ReadAllText(context.Request.PhysicalPath);
			context.Response.Write(output);
		}
		
		public bool IsReusable
		{
			get
			{
				return true;
			}
		}
		
	}
}

