using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace WebApi.Test.ioC.ExHandler
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        private readonly ICustomLogger _logger;
        public GlobalExceptionHandler(ICustomLogger logger)
        {
            _logger = logger;
        }
        public async override Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            var exception = context.Exception;

            _logger.LogException(exception);

            var mappedException = await context.MapException();

            string errorMessage = exception.Message;
            var response = context.Request.CreateResponse(mappedException,
                new
                {
                    Message = errorMessage
                });

            response.Headers.Add("X-Error", errorMessage.Replace(Environment.NewLine, ""));
            context.Result = new ResponseMessageResult(response);
        }

    }
}