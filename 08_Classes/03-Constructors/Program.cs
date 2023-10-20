using _03_Constructors.Entities;

//Constructors -> defines how we "new-up" a version of the object
// "versions" -> called overloads

//Syntax for a constructor:
//* 1. Access Modifier -> public, private(default), protected(inheritance),internal (constrained to assembly)
//* 2. Name of the Type, in our case Donut
//* 3. Parenthesis that will/can contain perameters
//* 4. The body that executes the code.


Donut donut = new Donut("Jelly Filled");

System.Console.WriteLine(donut._donutType);

// DateTime today = new DateTime();

Donut donut1 = new Donut("Creme Filled");
System.Console.WriteLine(donut1._donutType);
