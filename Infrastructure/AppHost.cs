using Funq;
using ServiceStack;
using System.Reflection;

namespace ServiceStackApp.Infrastructure
{
    public class AppHost : AppHostBase
    {
        public AppHost(string serviceName, params Assembly[] assembliesWithServices) : base(serviceName, assembliesWithServices)
        {
        }

        public override void Configure(Container container)
        {
            var register = new AppServicesRegister(this);
            register.Init();
        }
    }
}
