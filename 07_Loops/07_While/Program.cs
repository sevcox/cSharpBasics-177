//While Loops
// define a variable -> this will be used for the while loops boolean expression
int number = 0;

while(number <= 100)
{
    System.Console.WriteLine(number);

    //count up by one, to avoid an infinate loop
    number++;
    //++number;
    //number+=1;
}

//! Infinate loops (our enemy)
/*
!   This loop never ends!!!!!
    while(number == 0)
    {
        Console.WriteLine("Oh,Sh*T!);
    }
*/

//we can control behaviour
int value2 = 100;

while(value2 > 0)
{
    value2--;

    // if(value2 == 90)
    // {
    //     System.Console.WriteLine("We are going to 'Jump' out of the loop!");
    //     break;
    // }
    // if(value2 == 80)
    // {
    //     System.Console.WriteLine("We will just 'Return' or leave the loop");
    //     return;
    // }
    if(value2 == 10)
    {
        System.Console.WriteLine($"Lets just carry on with the loop: {value2}");
        continue;
    }
    System.Console.WriteLine(value2);
}

//do while
// THIS WILL ALWAYS RUN AT LEAST ONCE!!!!

do
{
    System.Console.WriteLine($"Hello World! {value2}");
    value2--;
    System.Console.WriteLine(value2);
}
while(value2 > 50);