using Autofac;
using DependencyInversionSwitch.Example2;

namespace DependencyInversionSwitch.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Lamp>().As<ISwitchable>();
            builder.RegisterType<Switch>().As<ISwitch>();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.Run();
            }
        }
    }
}