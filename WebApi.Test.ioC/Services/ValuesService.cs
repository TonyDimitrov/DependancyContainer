using System.Collections.Generic;
using WebApi.Test.ioC.DTO;

namespace WebApi.Test.ioC.Services
{
    public class ValuesService : IValuesService
    {
        // We simulate date from repository
        private readonly IList<string> repository;
        public ValuesService()
        {
            this.repository = new List<string> { "value 1", "value 2", "value 3", "value 4" };
        }
        public IEnumerable<string> All()
        {
            return this.repository;
        }
        public void Add(string value)
        {
            this.repository.Add(value);
        }

        public int Count()
        {
            return this.repository.Count;
        }

        public bool Delete(string value)
        {
            if (!this.repository.Contains(value))
            {
                return false;
            }

            this.repository.Remove(value);

            return true;
        }

        public bool Update(UpdateValueDTO update)
        {
            if (this.repository.Count == 0
                || this.repository.Count <= update.AtIndex
                || update.AtIndex < 0)
            {
                return false;
            }

            this.repository[update.AtIndex] = update.Value;

            return true;
        }
    }
}