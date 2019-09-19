namespace DependencyInversionSwitch.Example1
{
    public class Switch
    {
        private readonly Light light;
        private bool isSwitched;

        public Switch(Light light)
        {
            this.light = light;
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