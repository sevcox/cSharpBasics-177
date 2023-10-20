namespace _00_Vehicle.Entities
{
    public class SuperMario
    {
        public SuperMario()
        {

        }

        public SuperMario(int lives, int coins, PowerUpType powerUpType)
        {
            Lives = lives;
            Coins = coins;
            PowerUpType = powerUpType;
        }

        public int Lives { get; set; } = 3;
        public int Coins { get; set; } = 1;
        public PowerUpType PowerUpType { get; set; }
        public float Speed { get; set; } = 3.7f;

        public void PoweredUp()
        {
            Random rnd = new Random();
            Thread.Sleep(500);
            int poweredUpValue = rnd.Next(0, 3);  //0 - 2
            ActivatePowerUp(poweredUpValue);
        }

        private void ActivatePowerUp(int poweredUpValue)
        {
            switch (poweredUpValue)
            {
                case 1:
                    PowerUpType = PowerUpType.Fire_Flower;
                    System.Console.WriteLine("You activated the Fire Flower");
                    break;

                case 2:
                    PowerUpType = PowerUpType.Ice_Flower;
                    System.Console.WriteLine("You activated the Ice Flower");
                    break;

                default:
                    PowerUpType = PowerUpType.Mushroom;
                    System.Console.WriteLine("You activated the Mushroom...BIG");
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Lives}\n{Coins}\n{PowerUpType}";
        }
    }
}