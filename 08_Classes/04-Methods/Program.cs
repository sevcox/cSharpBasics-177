//Methods

//Usually used in a Class, and defines the 'actions' that the Class can proform

//machines that proform small 'modular' tasks

// They can give us something back (return value)

// They can do work, and return 'nothing' (void)

/*
     1       2       3       4
    public void SayHello(string name)
    {
             5
        Console.WriteLine($"Hello {name}")
    }

*/

//* 1. Is the access modifier: public , private, protedted, internal
//* 2. RETURN type (void, which means nothing is returned after the 'work' is done)
//* 3. + 4.  -> Method Signature, this is used for 'method overloading'
//* 5. -> Method body -> The task that is performed when the method is called


//todo:        parameters!
void SayHello(string name)
{
    System.Console.WriteLine($"Hello {name}");
}

//At runtime:
// method invocation
//todo:    arguments!
SayHello("Bill Esquire");

// method invocation
//todo:    arguments!
SayHello("Ted Theodore Rogan");

void Greeting()
{
    System.Console.WriteLine("Hello!");
}

// method invocation -> calling the method
Greeting();
// method invocation
Greeting();
// method invocation
Greeting();
// method invocation
Greeting();

//method that adds two integers together
// we also want the method to give us somthing back (return type)
int AddMe(int valueA, int valueB)
{
    int answer = valueA + valueB;
    return answer;

    // return valueA + valueB;
}

System.Console.WriteLine($"3 + 5 = {AddMe(3, 5)}");

int sum = AddMe(10, 2); //12
System.Console.WriteLine(AddMe(sum, sum));

//Subtraction
int SubtractMe(int valueA, int valueB)
{
    return valueA - valueB;
}

System.Console.WriteLine(SubtractMe(10, 2));  //8

int SubtractMeDouble(double valueA, double valueB)
{
    //We need to "chopp-off" the decimal values
    return Convert.ToInt32(valueB - valueA);
}

System.Console.WriteLine(SubtractMeDouble(10.72, 32.33));

double SquareMe(int value)
{
    return value * value;
}

System.Console.WriteLine(SquareMe(100));
System.Console.WriteLine(SquareMe(10));


//crazy? 
System.Console.WriteLine(SquareMe(AddMe(sum,3)));

int CrazyMath_AddUs(params int[] values)
{
    //starting point:
    int startingPoint = 0;

    foreach (int integer in values)
    {
        startingPoint += integer;
    }

    return startingPoint;
}

int addedValues = CrazyMath_AddUs(1,7,8,9,10,200,22,300,1000,40);
System.Console.WriteLine(addedValues);

int addedValues2 = CrazyMath_AddUs(3,2);
System.Console.WriteLine(addedValues2);

//Set up something random

Random rnd = new Random();

void GetRandomGreeting()
{
    //make a string array that will hold all of the greetings
    string[] availableGreetings =
    {
        "Hello", //0
        "Howdy", //1
        "Holla", //2
        "Yo", //3
        "Greetgings", //4
    };

    // 0 inclusive
    // 5 exclusive (not added)
    int randomNumber = rnd.Next(0,5);  // 0 - 4

    string randomGreeting = availableGreetings[randomNumber];

    System.Console.WriteLine($"randomGreeting: {randomGreeting}");
}

// GetRandomGreeting();

  string[] availableGreetings =
    {
        "Hello", //0
        "Howdy", //1
        "Holla", //2
        "Yo", //3
        "Greetgings", //4
    };


 string[] availableGreetings2 =
    {
        "Dude", //0
        "Where", //1
        "is", //2
        "My", //3
        "Car?", //4
    };

void GetRandomGreetingRefactored(string[] greetings)
{
     // 0 inclusive
    // 5 exclusive (not added)
    int randomNumber = rnd.Next(0,5);  // 0 - 4

    string randomGreeting = greetings[randomNumber];

    System.Console.WriteLine($"randomGreeting: {randomGreeting}");
}

GetRandomGreetingRefactored(availableGreetings);
GetRandomGreetingRefactored(availableGreetings2);

