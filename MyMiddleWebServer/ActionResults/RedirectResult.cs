using System.Net;

namespace MyMiddleWebServer.ActionResults;

public class RedirectResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        context.Response.Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    }
}