using Serilog;
using System;

namespace WebApi.Test.ioC.ExHandler
{
    public class SerilogLoger : ICustomLogger
    {
        static SerilogLoger()
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }
        public void LogException(Exception ex)
        {
            Log.Logger.Error(ex, $"{Environment.NewLine}" +
                $"Exception type: {ex.GetType()}{Environment.NewLine}" +
                $"Exception stacktrace: {ex.StackTrace}{Environment.NewLine}");
        }
    }
}