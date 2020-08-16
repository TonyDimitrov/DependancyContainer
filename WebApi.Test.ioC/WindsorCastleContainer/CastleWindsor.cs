using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System.Web.Http;

namespace WebApi.Test.ioC.WindsorCastleContainer
{
    public class CastleWindsor
    {
        private WindsorContainer _container = new WindsorContainer();

        public void Initialize()
        {
            _container.Install(new IWindsorInstaller[] { 
                new WindsorApiControllerInstaller()
            });
            GlobalConfiguration.Configuration.DependencyResolver = new DependencyResolver(_container.Kernel);
        }

        public void RegisterTransient<TInt, TImpl>()
            where TInt : class
            where TImpl : TInt
        {
            _container.Register(Component
            .For<TInt>()
            .ImplementedBy<TImpl>()
            .LifestyleTransient());
        }

        public void RegisterScoped<TInt, TImpl>()
            where TInt : class
            where TImpl : TInt
        {
            _container.Register(Component
            .For<TInt>()
            .ImplementedBy<TImpl>()
            .LifestyleScoped());
        }

        public void RegisterSingleton<TInt, TImpl>()
            where TInt : class
            where TImpl : TInt
        {
            _container.Register(Component
            .For<TInt>()
            .ImplementedBy<TImpl>()
            .LifestyleSingleton());
        }
    }
}