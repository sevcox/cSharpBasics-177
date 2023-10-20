namespace _00_Vehicle.Entities
{
    public class Indicator
    {
        public bool IsFlashing {get; private set;}

        public void TurnOn()
        {
            IsFlashing = true;
        }

        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
}