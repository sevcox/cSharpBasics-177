// Booleans

// True/False values (can store)

bool isCool = false;
isCool = true;
System.Console.WriteLine(isCool);

//todo: Booleans and logical operators
//* Operators that perform logic
//* AND (&&)
//* OR  (||)
//* NOT (!)

//NOT 
// C# negation operator, we call it the bang operator (!)
//!    !isCool this will evalueate to the opposite to whatever it is
System.Console.WriteLine(!isCool);

//AND
// C# use ampersands (&) to indicate AND statements
// A single (&) evalueates both conditions ALWAYS
// (&&) the right side will only be evaluated "if needed"

//OR
// C# uses pipes (|) to indicate OR statements
// Similar to AND, one pipe checks both conditions
// and (||) evaluates the first then the right

//XOR
// C# use the caret (^) indicates XOR statements

//--Boolean Operators
System.Console.WriteLine("------------------------------------");
//todo: Negation Operator
bool isTrue = !false;  //true
System.Console.WriteLine(isTrue);

bool isFalse = !true;  //false
System.Console.WriteLine(isFalse);

//todo: And Operator
bool trueAndExample = true && true;  //true -> b/c both 'operands' are true
System.Console.WriteLine("isTrue: " + trueAndExample);

bool falseAndExample = true && false; //false -> b/c both 'operands' and not true
System.Console.WriteLine(falseAndExample);

//todo: Or Operator
bool trueOrExample = true || false;  //true -> b/c one of these is 'true'
System.Console.WriteLine(trueOrExample);

bool falseOrExample = false || false; //false -> b/c both of these is 'false'
System.Console.WriteLine(falseOrExample);

//todo: XOR
bool trueExclusiveOr = true ^ false; //true both are different
System.Console.WriteLine($"true XOR false = {trueExclusiveOr}");

bool falseExclusiveOr = false ^ false; //false b/c they are both the same 
System.Console.WriteLine($"false XOR false = {falseExclusiveOr}");

bool falseExclusiveOr2 = true ^ true; //false b/c they are both the same
System.Console.WriteLine($"true XOR true = {falseExclusiveOr2}");


System.Console.WriteLine(true ^ true); //false
System.Console.WriteLine(true ^ false); //true
System.Console.WriteLine(false ^ true); //true
System.Console.WriteLine(false ^ false); //false

//* Comparison operators

//* Equal (==)
//* Not Equal (!=)
//* Greater than (>)
//* Less than (<)
//* Greater than or equal to (>=)
//* Less than or equal to (<=)

//* Examples:
bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqual = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqual}");

bool isLessThan = 5 < 5;
bool isLessThanOrEqual = 5 <= 5;
System.Console.WriteLine($"5 < 5 is {isLessThan}, and 5 <= 5 is {isLessThanOrEqual}");

bool equality = 17 == 19; //false
bool inequality = 17 != 19; //true;
System.Console.WriteLine($"17 == 19 is {equality}, and 17 != 19 is {inequality}");


