using MyMiddleWebServer.Controllers;
using System.Globalization;
using System.Net;
using System.Reflection;

namespace MyMiddleWebServer.Middlewares;

public class MvcMiddleware : IMiddleware
{
    public HttpHandler? Next { get; set; }

    public void Handle(HttpListenerContext context)
    {
        string? url = context.Request.RawUrl;
        if (!string.IsNullOrEmpty(url))
        {
            var sections = url.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var controller = sections[0].First().ToString().ToUpper(CultureInfo.InvariantCulture) + string.Join("", sections[0].Skip(1));
            var controllerName = $"MyMiddleWebServer.Controllers.{controller}Controller";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type? type = assembly.GetType(controllerName);
            if (type != null)
            {
                Controller? controllerObj = Activator.CreateInstance(type) as Controller;

                if (controllerObj is not null)
                {
                    string methodName = sections[1].First().ToString().ToUpper(CultureInfo.InvariantCulture) + string.Join("", sections[1].Skip(1));
                    controllerObj.Context = context;
                    MethodInfo? methodInfo = type.GetMethod(methodName);
                    methodInfo?.Invoke(controllerObj, null);
                }
            }

        }
        Next?.Invoke(context);
    }
}
