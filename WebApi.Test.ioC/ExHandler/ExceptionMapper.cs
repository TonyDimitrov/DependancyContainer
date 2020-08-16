using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace WebApi.Test.ioC.ExHandler
{
    public static class ExceptionMapper
    {
        public static Task<HttpStatusCode> MapException(this ExceptionHandlerContext context)
        {
            // TODO
            // Only sceleton
            if (context.Exception.GetType() == typeof(InvalidOperationException))
            {

            }
            else if (context.Exception.GetType() == typeof(Exception))
            {

            }

            return Task.FromResult(HttpStatusCode.InternalServerError);
        }
    }
}