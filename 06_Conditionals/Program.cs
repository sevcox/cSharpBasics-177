//Conditionals 

//Handles the decision making process w/n an application at runtime

//Anytime we want an application to do work based on any condition


//Ex: (sudo code...)
// if user is logged in -> we can redirect the user to the login page
// if its the users birthday -> tell them happy birthday
// if user doesn't have the necessary role -> deny them access

bool isRaining = true;
bool isGoingOutside = false;

//if statements
//Formula:
// Given a boolean, if the boolean evaluates to true -> do the action you are given


// if(true)
// {
//     System.Console.WriteLine("Code runs here if true");
// }

if(isRaining)
{
    System.Console.WriteLine("It's raining out!");
}


//Multiple variables in an if statement
if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring out an umbrella!");
}

// if(isRaining)
// {
//     if(isGoingOutside)
//     {
//         System.Console.WriteLine("Better bring out an umbrella!");
//     }
// }

//Or
if (!isRaining || isGoingOutside == false)
{
    System.Console.WriteLine("I don't need an umbrella.");
}

//XOR
if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I'll go outside if its not raining.");
}

//Challenge
//write an if statement that uses a new boolean called 'hasUmbrella' 

bool hasUmbrella; //false
//...somewhere in code land...
hasUmbrella = true;
isGoingOutside = true;

if(hasUmbrella && isGoingOutside && isRaining)
{
    System.Console.WriteLine("Good thing I have my umbrella, so I can go outside while its raining.");
}

