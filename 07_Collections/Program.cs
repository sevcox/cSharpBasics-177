//Collections -> how we store a collection of items in C#

//All collections start at index 0


//! DONT DO THIS....
object[] stuff = new object[5];
//technically stuff goes from stuff[0] -> stuff[4] , 0,1,2,3,4
stuff[0] = "Terry";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill Bob";
stuff[4] = 22.22M;

foreach(object item in stuff)
{
    System.Console.WriteLine(item);
}

//todo: WE NEED 'TYPE SAFETY'
string stringExample = "Hello world!";

//* Arrays are FIXED values
//* They ALWAYS start at 0
//* They are QUICK when it comes to retriving data
//* But, when it comes to UPDATING data IT SUCKS

//Array of type string (object initialization)
string[] stringArray = 
{
    "Hello",  //0
    "World",  //1
    "Why",
    "is it",
    "Always",
    stringExample,
    "?",
    "Bevis",
    "Butt-Head"
};

string[] myArray = new string[3];

myArray[0] = "Dude";
myArray[1] = "Whats";
myArray[2] = "up";
// myArray[3] = "Man?";

System.Console.WriteLine(stringArray[3]);  //"is it"
System.Console.WriteLine(stringArray[1]);  //"World"

//We can change a value at an index
stringArray[1] = "Hey there";

System.Console.WriteLine(stringArray[1]);

//Arrays have a 'length' property that will display how many items that are in the list
System.Console.WriteLine(stringArray.Length);

//List<T>  -> 'T' represents a generic type that the collection is composed of
// 'T' can be ANY TYPE

//Under the hood a List<T> is nothing more than a dyanmic array
// the array hits a particular max-count say 50, then the array inside of the List<T> will double itself
// List<T> has a .Count property, which can be called as a method (sometimes)

//I want a collection of strings -> List<string>
List<string> listOfStrings = new List<string>();
listOfStrings.Add("Tj");
listOfStrings.Add("James");
listOfStrings.Add("Jed");

//System.Collections.Generic.List`1[System.String]  (reflection)
System.Console.WriteLine(listOfStrings);

foreach(string name in listOfStrings)
{
    System.Console.WriteLine(name);
}

List<int> listOfInts = new List<int>();
listOfInts.Add(1124);

System.Console.WriteLine(listOfInts[0]);

// listOfStrings.Remove("Tj");

// foreach(string name in listOfStrings)
// {
//     System.Console.WriteLine(name);
// }

listOfStrings.Remove(listOfStrings[listOfStrings.IndexOf("James")]);
System.Console.WriteLine("-------------------");
foreach(string name in listOfStrings)
{
    System.Console.WriteLine(name);
}

//Queue<T> -> F.I.F.O -> first in first out, think of a store line
// first in line is the first serviced
Queue<string> firstInFirstOut = new Queue<string>();

//add to the queue '.Enqueue()' 
firstInFirstOut.Enqueue("I'm First");
firstInFirstOut.Enqueue("I'm Second");

//we can see the Queue through iteration (looping)
//todo: but we cannot do anything but service the first item
foreach(string item in firstInFirstOut)
{
    System.Console.WriteLine(item);
}

//we can see who's next in line...   '.Peak()'
string firstIn = firstInFirstOut.Peek();
System.Console.WriteLine(firstIn);

//how to service who is next in line '.Dequeue()'
firstInFirstOut.Dequeue();

System.Console.WriteLine("-------------------");
firstIn = firstInFirstOut.Peek();
System.Console.WriteLine(firstIn);

//Dictionary<TKey,TValue>  -> key/value pair
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();
keyAndValue.Add(1,"Terry");
keyAndValue.Add(2,"Tj");

// System.Collections.Generic.Dictionary`2[System.Int32,System.String]
System.Console.WriteLine(keyAndValue);

foreach(KeyValuePair<int,string> values in keyAndValue)
{
    System.Console.WriteLine(values);
}

System.Console.WriteLine("------Keys------------");
//constraint to just show the 'keys' in the terminal
foreach(int key in keyAndValue.Keys)
{
    System.Console.WriteLine(key);
}

System.Console.WriteLine("------Values------------");
//constraint to just show the 'values' in the terminal
foreach(string value in keyAndValue.Values)
{
    System.Console.WriteLine(value);
}

string tj = keyAndValue[2];
System.Console.WriteLine(tj);

//Other Collections
SortedList<int,string> sortedKeyValuePair = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();
Stack<string> lastInFirstOut = new Stack<string>();

//------------------Use Random ----------------
// This is based on CPU clock ticks!
Random rnd = new Random();

int number = rnd.Next(5,20);  // 5->19 (b/c the second value in rnd.Next() '20' is exclusive)
System.Console.WriteLine(number);

