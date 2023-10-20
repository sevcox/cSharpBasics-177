using _05_Properties.Entities;
//Properties

//These give the developer the ability to read and write to a specific piece of data (or private field)

//These live on an object (Class)
// They Read, Write, and Compute

//Anatomy
//* public Type variableName {get;set;}

//* {get;set;} -> these are 'read' "{get;}" 
//*               and 'write' {set;}  methods

//* These are shorthand for read/write methods

//* PascalCasing for properties -> public int FirstLettersAreCapitalized {get;set;}


Donut donut = new Donut();
donut.Filling = "Boston Creme"; //set; (write)
donut.Topping = "Sprinkles";
donut.Price = 3.00m;
donut.IsSpecial = true;
// System.Console.WriteLine(donut.Filling);
// System.Console.WriteLine(donut.Topping);
// System.Console.WriteLine(donut.Price);
// System.Console.WriteLine(donut.IsSpecial);

//full constructor -> Complete creation of the object on the fly
Donut donut1 = new Donut("Glazed","Boston Creme","N/A",false);
// System.Console.WriteLine(donut1.Filling);
// System.Console.WriteLine(donut1.Topping);
// System.Console.WriteLine(donut1.Price);
// System.Console.WriteLine(donut1.IsSpecial);

//empty constructor -> no arguments
Donut plain = new Donut();
plain.Price = 1_000_000M;
Donut plain2 = new Donut();
// System.Console.WriteLine(plain.GetDonutType());
// System.Console.WriteLine(plain2.GetDonutType());

//constructor that takes in a donutType -> partial creation (only what we NEED)
Donut donut2 = new Donut("Yabba Dabba Do!!!");
// System.Console.WriteLine(donut2.GetDonutType());


System.Console.WriteLine(donut);
System.Console.WriteLine("-------------------");
System.Console.WriteLine(donut1);
System.Console.WriteLine("-------------------");
System.Console.WriteLine(donut2);
System.Console.WriteLine("-------------------");
System.Console.WriteLine(plain);

