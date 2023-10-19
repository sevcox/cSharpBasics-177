Console.Clear();
//Foreach

//foreach(declaredIterator in enumerableCollection)
//{
//   body...
//}

Array array;
List<string> stuff;

string instructorName = "Amanda";

//we want to make a collection
string[] instructors = new string[]
{
    "Michael",
    "Joshua",
    instructorName
};

foreach (string instructor in instructors)
{
    System.Console.WriteLine(instructor);
}


int[] intArray = new int[] { 1, 2, -3, 4, 5, 0 };

foreach (int number in intArray)
{
    // if(number <0)
    // System.Console.WriteLine($"This is a negative number. {number}");
    // else if(number>0) 
    // System.Console.WriteLine($"This is a positive number. {number}");
    // else
    // System.Console.WriteLine($"This is a neutral number. {number}");

    switch (number)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            System.Console.WriteLine($"This is a positive number: {number}");
            break;
        case -3:
            System.Console.WriteLine($"This is a negative number: {number}");
            break;
        default:
            System.Console.WriteLine($"This is a nutral number: {number}");
            break;
    }
}