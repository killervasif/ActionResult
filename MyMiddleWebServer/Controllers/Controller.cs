using MyMiddleWebServer.ActionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyMiddleWebServer.Controllers;

public abstract class Controller
{
    public HttpListenerContext Context { get; set; }

    public ViewResult View()
    {
        var result = new ViewResult();
        result.ExecuteResult(Context);
        return result;
    }

    public ContentResult Content()
    {
        var result = new ContentResult();
        result.ExecuteResult(Context);
        return result;
    }

    public JsonResult Json()
    {
        var result = new JsonResult();
        result.ExecuteResult(Context);
        return result;
    }

    public EmptyResult Empty()
    {
        var result = new EmptyResult();
        result.ExecuteResult(Context);
        return result;
    }

    public FileResult File()
    {
        var result = new FileResult();
        result.ExecuteResult(Context);
        return result;
    }

    public RedirectResult Redirect()
    {
        var result = new RedirectResult();
        result.ExecuteResult(Context);
        return result;
    }
}
