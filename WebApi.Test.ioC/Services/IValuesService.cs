using System.Collections.Generic;
using WebApi.Test.ioC.DTO;

namespace WebApi.Test.ioC.Services
{
    public interface IValuesService
    {
        IEnumerable<string> All();

        int Count();

        void Add(string value);

        bool Update(UpdateValueDTO update);

        bool Delete(string value);
    }
}
