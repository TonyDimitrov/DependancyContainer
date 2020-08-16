using System.Web.Mvc;
using WebApi.Test.ioC.Services;

namespace WebApi.Test.ioC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValuesService valuesService;

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
