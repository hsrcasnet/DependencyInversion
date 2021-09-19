using Microsoft.Extensions.DependencyInjection;
using SwitchLibrary;
using SwitchLibrary.Example2;

namespace SwitchConsoleApp.MicrosoftExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create container
            var serviceCollection = new ServiceCollection();

            // Register services
            serviceCollection.AddSingleton<IApplication, Application>();
            serviceCollection.AddSingleton<ISwitchable, Lamp>();
            serviceCollection.AddSingleton<ISwitch, Switch>();

            // Build container
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Create new scope and resolve root object
            var application = serviceProvider.GetService<IApplication>();
            application.Run();
        }
    }
}
