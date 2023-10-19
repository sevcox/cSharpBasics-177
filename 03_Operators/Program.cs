
// addition (+)

// subtraction (-)

// multiplication (*)

// division (/)

// remainder [Modulus, Modulo] (%)

//unary operators
//Ex: increment++ (counting up by one)
//Ex: increment-- (counting down by one)

int studentCount = 30;

//* we can add one to student in many ways
// studentCount += 1;
studentCount++; //31
System.Console.WriteLine(studentCount);

//todo: we can add 'after-the-fact'
studentCount++;  //32

//todo: we can increment up by one before-the-fact
++studentCount; //33

System.Console.WriteLine(studentCount);
studentCount--;  //32
--studentCount;  //31 

System.Console.WriteLine(studentCount);

//addition (expression)
int additionResult = 5 + 2;
System.Console.WriteLine("5 + 2 = " + additionResult);


//subtraction
int subtractionResult = 5 - 2;
System.Console.WriteLine("5 - 2 = " + subtractionResult);

//multiplication
int multiplicationRestult = 5 * 2;
System.Console.WriteLine("5 * 2 = " + multiplicationRestult);

//division
int divisionResult = 5 / 2;
System.Console.WriteLine("5 / 2 = "+ divisionResult);

//Modulus
System.Console.WriteLine(10%2);  //0
System.Console.WriteLine(10%9);  //1
System.Console.WriteLine(16%3);  //1
System.Console.WriteLine(19%3);  //1

int powerOf2 = Convert.ToInt32(Math.Pow(10.0,2.0));
System.Console.WriteLine(powerOf2);

