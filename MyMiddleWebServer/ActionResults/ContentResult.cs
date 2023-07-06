using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.ActionResults;

public class ContentResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        var bytes = Encoding.UTF8.GetBytes("Data from mehtod with Type ContentResult");
        context.Response.ContentType = "text/plain";
        context.Response.OutputStream.Write(bytes);
    }
}
