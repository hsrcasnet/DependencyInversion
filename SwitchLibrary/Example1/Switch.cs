namespace SwitchLibrary.Example1
{
    public class Switch
    {
        private readonly Light light;
        private bool isSwitched;

        public Switch()
        {
            this.light = new Light();
        }

        public void Toggle()
        {
            this.isSwitched = !this.isSwitched;
            if (this.isSwitched)
            {
                this.light.TurnOn();
            }
            else
            {
                this.light.TurnOff();
            }
        }
    }
}