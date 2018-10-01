using System;

namespace DependencyInversionSwitch.Example2
{
    public interface ISwitchable
    {
        void TurnOn();

        void TurnOff();
    }

    public class Lamp : ISwitchable
    {
        private bool isOn;

        public void TurnOn()
        {
            this.isOn = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Turned on!");
        }

        public void TurnOff()
        {
            this.isOn = false;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Turned off!");
        }
    }

    public class Switch : ISwitch
    {
        private readonly ISwitchable switchable;
        private bool isSwitched;

        public Switch(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Toggle()
        {
            this.isSwitched = !this.isSwitched;
            if (this.isSwitched)
                this.switchable.TurnOn();
            else
                this.switchable.TurnOff();
        }
    }

    public interface ISwitch
    {
        void Toggle();
    }
}