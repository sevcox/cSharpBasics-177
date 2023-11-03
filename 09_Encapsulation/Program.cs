using System.Runtime.InteropServices.Marshalling;
using _09_Encapsulation.Entity;

    // OOP
    // simple, resuable pieces of code
    // revolves around classes and objects


    // Encapsulation
    // adds security
    // protects against common mistakes
    // protects ip
    // supportable
    // hide complexity 


    Person john = new Person("John", "Smith", "18/05/1986");

    Console.WriteLine(john.FirstName);
    Console.WriteLine(john.LastName);

    string birthday = john.GetFormattedBirthday();
    Console.WriteLine(birthday);