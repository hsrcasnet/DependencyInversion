namespace SwitchLibrary.Example1
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
}
