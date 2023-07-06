using System.Net;

namespace MyMiddleWebServer.ActionResults;

public class EmptyResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        Console.WriteLine("Some Action happened in back but no change in the view");
    }
}