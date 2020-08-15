using System.Collections.Generic;
using System.Web.Http;
using WebApi.Test.ioC.DTO;
using WebApi.Test.ioC.Services;

namespace WebApi.Test.ioC.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IValuesService valuesService;

        public ValuesController(IValuesService valuesService)
        {
            this.valuesService = valuesService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return this.valuesService.All();
        }

        // GET api/values/5
        public int Count()
        {
            return this.valuesService.Count();
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] string value)
        {
            this.valuesService.Add(value);

            return this.Ok();
        }

        // PUT api/values/5
        public IHttpActionResult Put([FromBody] UpdateValueDTO update)
        {

            if (!this.valuesService.Update(update))
            {
                return this.BadRequest("Value was not updated");
            }

            return this.Ok(203);
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(string value)
        {
            if (!this.valuesService.Delete(value))
            {
                return this.BadRequest("Value was not deleted");
            }

            return this.Ok(204);
        }
    }
}
