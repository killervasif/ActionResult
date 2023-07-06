using System.Net;

namespace MyMiddleWebServer.ActionResults;

public class ViewResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        var sections = context?.Request?.RawUrl?.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var folder = sections[0];
        var file = sections[1];
        var helperPath = $"{Directory.GetCurrentDirectory().Split("\\bin")[0]}";
        var path = $"{helperPath}/Views/{folder}/{file}.html";
        var bytes = File.ReadAllBytes(path);
        context.Response.ContentType = "text/html";
        context.Response.OutputStream.Write(bytes);
    }
}