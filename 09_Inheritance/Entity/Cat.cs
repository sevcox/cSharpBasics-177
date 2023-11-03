namespace _09_Inheritance.Entity;

public class Cat : Animal
{
    public double ClawLength { get; set; }

    public Cat()
    {
        Console.WriteLine("This is a Cat constructor");
        IsMammal = true;
        DietType = DietType.Carnivore;
    }
}

public class TabbyCat : Cat
{
    public TabbyCat() 
    {
        Console.WriteLine("This is a Tabby Cat Constructor.");
    }
}