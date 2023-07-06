using System.Net;

namespace MyMiddleWebServer.ActionResults;

public interface IActionResult
{
    void ExecuteResult(HttpListenerContext context);
}