using DependencyInversionSwitch.Example2;

namespace DependencyInversionSwitch.Console
{
    public class Application : IApplication
    {
        private readonly ISwitch @switch;

        public Application(ISwitch @switch)
        {
            this.@switch = @switch;
        }

        public void Run()
        {
            while (true)
            {
                @switch.Toggle();
                System.Console.ReadKey();
            }
        }
    }
}