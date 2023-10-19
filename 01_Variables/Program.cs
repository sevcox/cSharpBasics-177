using System;

//* Variables -> are just containers in C# (empty boxes)

//* But there is a catch

//* We have to tell the 'compiler' what kind of data can be stored in that container

//* C# is a STRONGLY Typed Language -> if you don't do things C#'s way the app will BLOW UP!!! (errors will occur)

//* Js example
/*
    terry = "Terry"
    age = 30
*/

//1      2   3    4
string terry = "Terry";

//todo: 1 Type
//todo: 2 variable name
//todo: 3 assignment operator
//todo: 4 value

Console.WriteLine(terry);

//* dotnet run --project .\01_Variables\ -> get our app to run....

//* ctrl+shift+p -> .NET:Restart Language Server

Console.WriteLine("What is your favorite color");

//* how to make a user response?
string userResponse = Console.ReadLine()!;      //* whatever the user types will be stored inside of the variable 
                                                //*  'userResponse'

//* this will be displayed in the terminal
System.Console.WriteLine("You said your favorite color is: " + userResponse);

System.Console.WriteLine("What is your name?");
string newName = Console.ReadLine()!;

System.Console.WriteLine("Ok, so your name is " + newName);
