namespace _00_Vehicle.Entities
{
    public class Vehicle
    {
        public Vehicle()
        {
            L_Indicator = new Indicator();
            R_Indicator = new Indicator();
        }

        //properties -> define what we percive a vheicle to be
        public string? Make { get; set; }
        public string? Model { get; set; }
        public double? Milage { get; set; }
        public VehicleType VehicleType { get; set; }

        // IsRunning will be modified by Public Methods!
        public bool IsRunning { get; private set; }

        public void TurnOn()
        {
            IsRunning = true;
            System.Console.WriteLine("The vehicle is TURNED ON!");
        }

        public void TurnOff()
        {
            IsRunning = true;
            System.Console.WriteLine("The vehicle is TURNED OFF!");
        }

        //another obj that this uses for indicators!!!
        public Indicator L_Indicator { get; set; }
        public Indicator R_Indicator { get; set; }

        public void IdicateRight()
        {
            R_Indicator.TurnOn();
            L_Indicator.TurnOff();
            System.Console.WriteLine("Turning Right");
        }

        public void IndiateLeft()
        {
            L_Indicator.TurnOn();
            R_Indicator.TurnOff();
            System.Console.WriteLine("Turning Left");
        }

        public void TurnOnHazzards()
        {
            L_Indicator.TurnOn();
            R_Indicator.TurnOn();

            for (int i = 0; i < 5; i++)
            {
                //Turn the cqu off for 500ms
                Thread.Sleep(500);
                System.Console.WriteLine("HAZZARDS!!!");
            }
        }

        public void ClearIndicators()
        {
            L_Indicator.TurnOff();
            R_Indicator.TurnOff();
            System.Console.WriteLine("Cleared Indicators!!! Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}