using System;

namespace SwitchLibrary.Example2
{
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
}