// Ternary Expressions

//it's a conditional operator (one-liner)

//* 3 parts

//    1                2                      3       
// boolean expression  ?   expression if true : expression if false


//1. boolean expression to be evalueated
//2. signal to the compile that we are using a ternary operator
//3. seperates the true : false evaluation

//Ex:
System.Console.WriteLine("Enter your age");

string response = Console.ReadLine()!;

//we don't want to pass in a 'string' type
// so we have to do a conversion of type int (b/c thats the type that we want)

// int age = int.Parse(response);
int age = Convert.ToInt32(response);

    string output = (age > 18) ? "Let's Party!" : "Your too young!!!";
    System.Console.WriteLine(output);

//*   try
//*   {
//*       int age = int.Parse(response);
  
//*       string output = (age > 18) ? "Let's Party!" : "Your too young!!!";
//*       System.Console.WriteLine(output);
//*   }
//*   catch(Exception e)
//*   {
//*       System.Console.WriteLine(e.Message);
//*   }
  
//*   System.Console.WriteLine("What is your name");
//*   string input = Console.ReadLine()!;
//*   System.Console.WriteLine($"Your name is {input}");