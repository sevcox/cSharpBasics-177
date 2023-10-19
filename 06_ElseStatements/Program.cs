//?:  what if the 'if' statement didn't work?
//?:  what else can we do?

bool isRaining = false;

if (!isRaining)
{
    System.Console.WriteLine("I'll cut the grass.");
}
else //defalut -> if all else 'fails' do this...
{
    System.Console.WriteLine("I guess I can't cut the grass.");
}

bool isGoingOutside = false;

if (isGoingOutside)
{
    System.Console.WriteLine("Make sure to dress for the weather.");
}
else
{
    System.Console.WriteLine("Sounds like a seater kind of day.");
}

//if..elseif..else
if (isGoingOutside)
{
    System.Console.WriteLine("Make sure to dress for the weather.");
}
else if (isRaining)
{
    System.Console.WriteLine("Its raining cats and dogs!");
}
else
{
    System.Console.WriteLine("Sounds like a seater kind of day.");
}

// user feeling input

System.Console.WriteLine("How are you felling (1-5)");

string userInput = Console.ReadLine()!;

if(userInput == "1")
{
    System.Console.WriteLine("I hope your day gets better.");
}
else if(userInput == "2")
{
    System.Console.WriteLine("Oh, sorry to hear that");
}
else if(userInput =="3")
{
    System.Console.WriteLine("Hope things improve");
}
else if(userInput == "4")
{
    System.Console.WriteLine("Good Stuff!");
}
else if(userInput == "5")
{
    System.Console.WriteLine("Wow, thats good to hear!");
}
else{
    System.Console.WriteLine("Invalid Key Entry.");
}