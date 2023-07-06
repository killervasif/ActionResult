using System.Net;

namespace MyMiddleWebServer.ActionResults;

public class FileResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        string filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\MyMiddleWebServer\MyMiddleWebServer\StaticFiles\somePdf.pdf";
        context.Response.ContentType = "application/pdf";
        var bytes = File.ReadAllBytes(filePath);
        context.Response.OutputStream.Write(bytes);
    }
}