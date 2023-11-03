namespace _09_Inheritance.Entity;

// abstract - BASE class - can NOT new it up
public abstract class Animal
{
    public int NumberOfLegs { get; set; }
    public bool IsMammal { get; set; }
    public bool IsFurry { get; set; }
    public DietType DietType { get; set; }

    public Animal()
    {
        Console.WriteLine("This is an Animal constructor.");
    }
}
