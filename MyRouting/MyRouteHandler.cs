using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Internal;

namespace MyRouting
{
    public class MyRouteHandler : IRouter
    {
        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            return null;
        }

        public Task RouteAsync(RouteContext context)
        {
            
            context.Handler = (c) =>
            {
                var printStr = $"{a},controller:{c.GetRouteValue("controller")}," +
                $"action:{c.GetRouteValue("action")},id:{c.GetRouteValue("id")}";

                return c.Response.WriteAsync(printStr);
            };
            return TaskCache.CompletedTask;
        }
    }
}