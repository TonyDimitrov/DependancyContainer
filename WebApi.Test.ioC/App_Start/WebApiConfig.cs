using System.Web.Http;
using WebApi.Test.ioC.Services;
using WebApi.Test.ioC.WindsorCastleContainer;

namespace WebApi.Test.ioC
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            CastleWindsor ioC = new CastleWindsor();
            ioC.Initialize();
            ioC.RegisterTransient<IValuesService, ValuesService>();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
