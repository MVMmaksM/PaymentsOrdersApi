using System;

namespace WebApi.Middlewares
{
    public class LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
    {
        public async Task InvokeAsync(HttpContext context) 
        {
            var request = context.Request;
            logger.LogInformation($"[{DateTime.Now}] request: {request.Method}|{request.Host.ToString() + request.Path + request.QueryString}" +
                $"|{request.Protocol}|{request.Scheme}");

            await next.Invoke(context);

            var responce = context.Response;
            logger.LogInformation($"[{DateTime.Now}] responce: {request.Method}|{request.Host.ToString() + request.Path + request.QueryString}" +
                $"|{request.Protocol}|{request.Scheme}");
        }
    }
}
