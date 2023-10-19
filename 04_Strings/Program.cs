//Strings

//Collection of characters
// Any text, a single character or number can be a string , "1" or "a"

// we make strings with (" ")

// 3 ways to 'set-up' a string...
// 1. Concatination
// 2. Composite Formatting
// 3. Interpolation


//todo: Concatination
string first = "The cars we sell are ";
string second = "BMW, Lexus, and Mercedes.";

string concatinatedResult = first + second;
System.Console.WriteLine(concatinatedResult);

//todo: Composite Formatting
string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);
System.Console.WriteLine(compositeResult);

//todo: String Interpolation:
string interpolationResult = $"Her name is still {firstName} {lastName}";
System.Console.WriteLine(interpolationResult);


//Challenge
//Practice these three ways of joining strings (3) more examples of each
