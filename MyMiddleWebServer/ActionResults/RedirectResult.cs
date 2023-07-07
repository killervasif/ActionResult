using System.Net;

namespace MyMiddleWebServer.ActionResults;

public class RedirectResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        context.Response.Redirect("https://youtu.be/fx2Z5ZD_Rbo");
    }
}