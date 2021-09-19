namespace SwitchLibrary.Example2
{
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
            {
                this.switchable.TurnOn();
            }
            else
            {
                this.switchable.TurnOff();
            }
        }
    }
}