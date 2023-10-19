// Switch
// 'switch' keyword
//  just like an 'if' statement but w/o the 'branching'

//1.  value that will be evaluated
//2. 'value' is going to be compared to a 'case'
//3.  "break" indecates that we are 'leaving' the switch statement
//4.  "default" -> if all else fails

System.Console.WriteLine("Please Input your name...");
//       1.
string name = Console.ReadLine()!;

switch (name)
{
    //this is the value that is being 'checked'
    case "pete":
    case "Pete":
        System.Console.WriteLine("Hi Pete");
        break;
    case "Susan":
        System.Console.WriteLine("Hi Susan");
        break;
    default:
        System.Console.WriteLine("Invalid Option (Name).");
        break;
}

System.Console.WriteLine("How are you feeling today (1-5)");
string userInput = Console.ReadLine()!;
switch (userInput)
{
    case "1":
        System.Console.WriteLine("I hope your day gets better.");
        break;
    case "2":
        System.Console.WriteLine("Oh, sorry to hear that.");
        break;
    case "3":
        System.Console.WriteLine("Hope things improve.");
        break;
    case "4":
        System.Console.WriteLine("Good Stuff!");
        break;
    case "5":
        System.Console.WriteLine("Wow, thats good to hear!");
        break;
    default:
        System.Console.WriteLine("Invalid Selection.");
        break;
}

//Challenge 
//Creating a switch statement
//want to output discriptions for a few of your friends
//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
    // what can you do with cases like "Paul" and "paul" as these are different values