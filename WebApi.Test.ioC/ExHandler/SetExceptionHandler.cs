using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace WebApi.Test.ioC.ExHandler
{
    public static class SetExceptionHandler
    {
        public static void GlobalExceptionHandler(this HttpConfiguration config, ICustomLogger logger)
        {
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler(logger));
        }
    }
}