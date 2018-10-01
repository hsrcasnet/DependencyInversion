namespace DependencyInversionSwitch.Example1
{
    public class Light
    {
        private bool isOn = false;

        public void TurnOn()
        {
            this.isOn = true;
        }

        public void TurnOff()
        {
            this.isOn = false;
        }
    }

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
                light.TurnOn();
            }
            else
            {
                light.TurnOff();
            }
        }
    }
}
