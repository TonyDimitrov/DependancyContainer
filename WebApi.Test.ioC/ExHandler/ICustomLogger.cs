using System;

namespace WebApi.Test.ioC.ExHandler
{
    public interface ICustomLogger
    {
        void LogException(Exception ex);
    }
}
