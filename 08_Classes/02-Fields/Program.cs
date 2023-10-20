using _02_Fields.Entities;
//Fields

// Its a variable that is declared directly inside of a type (Class)
// Also a member of the Class

//Anatomy of a Class

//Access Modifiers:
// public -> publicly accessable via all types
// private -> Only the containing class has access to the field
// protectd -> Only inheriting members has access to the field
// internal -> This field can only be used by object within its assembly


Donut donut = new Donut();
System.Console.WriteLine(donut); //reflection

donut._donutType = "Jelly Filled";
System.Console.WriteLine(donut._donutType); //"Jelly Filled"

Donut donut1 = new Donut();
donut1._donutType = "Glazed...";
System.Console.WriteLine(donut1._donutType); //"Glazed..."

