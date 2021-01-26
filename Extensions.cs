using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

namespace NitsyS
{
    public static class Extensions
    {
        public static IApplicationBuilder UseCustomErrorHandler(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            app.Use(async (context, next) =>
            {
                await next.Invoke().ConfigureAwait(false);
                int statusCode = context.Response.StatusCode;
                if (statusCode == 404)
                {
                    context.Response.StatusCode = statusCode;
                    await context.Response.WriteAsync($"Cannot get {context.Request.Path}").ConfigureAwait(false);
                }
                Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
                Console.WriteLine($"[Response Http Code] {context.Response.StatusCode}\n");
            });
            return app;
        }
    }
}