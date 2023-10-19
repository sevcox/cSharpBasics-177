using _02_Types;

Console.Clear();

//C# Types

//variable naming convention:
// camel-cased (typeNameIsCapitalized)
// first letter is lowercased and every other following words first letter is Capitalized

//bool (boolean) -> true/false
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

// integers -> whole numbers
int age = 20;
System.Console.WriteLine(age); //age -> displayed as a strnig in the terminal, but 'age' is not a string

//* decimal -> most percise decimal value in C#endregion
//* used to represent money
decimal accountBalance = 90_000m;
System.Console.WriteLine(accountBalance);

int i = 0;                           //32 integer value
//short sh = 32767;                   // 16 bit signed integer
//Int16 anotherShortEx = 32000;        
//byte by = 255;                     // a group of binary digits (usually eight) operated on as a unit

string s = "hey!";                     //string->  collection [] of characters (think a-string-of-characters)
System.Console.WriteLine(s.Length);   //works, b/c 'string' is an underlying array of characters

char c = 'i';                         //this represents a single character
System.Console.WriteLine(c);

string s2 = @"a\tree";               // use @ to specify a directory

bool b = false;

//long l = 7;                          // this is a LARGE INTGER VALUE. X2:
// -9Q - 9Q (data science)

decimal d = 99.99999999m;           //128-bit percision, 28-29 values after the decimal point (Money)

double db = 7.8000d;                 // 'd' 15-16 digits after decimal point, half the size of a double

float f = 10.8f;                     // 'f' stored in 32 bits, half the size of a double

int? ni = null;                     // int is a Struct and it defaults to zero, but if we (int?)
                                    // we turn it to a "nullable int"

//dealing with decimals
//these values should truncate
System.Console.WriteLine(1.25878058705150144511210841f);
System.Console.WriteLine(1.25878058705150144511210841d);
System.Console.WriteLine(1.25878058705150144511210841m);

//Dealing with dates!!!
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

//we can make our own date
DateTime birthday = new DateTime(1972, 06, 20);
System.Console.WriteLine(birthday);

//Enums -> types that are represented by numbers
PastryType myPastry = PastryType.Cake;
PastryType anoterOne = PastryType.Croissant;
System.Console.WriteLine("I like " + myPastry + " and " + anoterOne);


