using Autofac;
using SwitchLibrary;
using SwitchLibrary.Example2;

namespace SwitchConsoleApp.AutofacExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create container
            var builder = new ContainerBuilder();

            // Register services
            builder.RegisterType<Application>().As<IApplication>().SingleInstance();

            builder.RegisterType<Lamp>().As<ISwitchable>();
            builder.RegisterType<Switch>().As<ISwitch>();

            // Build container
            var container = builder.Build();

            // Create new scope and resolve root object
            using (var scope = container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.Run();
            }
        }
    }
}