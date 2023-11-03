using _09_Abstraction.Entity;


    Person john = new Person("John", "Smith", "18/05/1986");
    string name = john.GetName();
    Console.WriteLine(name);

    Console.WriteLine(john.GetAge());
