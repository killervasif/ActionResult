using System.Net;

namespace MyMiddleWebServer.ActionResults;

public class EmptyResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        Console.WriteLine("EmptyResult");
    }
}