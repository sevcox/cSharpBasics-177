using _00_Vehicle.Entities;

// Console.Clear();

// Vehicle veh1 = new Vehicle();

// veh1.TurnOn();
// veh1.IndiateLeft();

// Console.ReadKey();
// veh1.ClearIndicators();

// veh1.TurnOnHazzards();
// Console.ReadKey();
// veh1.ClearIndicators();

SuperMario mario = new SuperMario();
mario.PoweredUp();

SuperMario luigi = new SuperMario(7,70,PowerUpType.Fire_Flower);

System.Console.WriteLine(luigi);
