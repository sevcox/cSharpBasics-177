//For loops -> use these when we want to retrive data from collections

//* 1. for keyword
//* 2. initializer
//* 3. condition
//* 4. iterator ++, --, +=,-=,/=,*=


//1    //2     //3      //4
//* for (int i = 0; i < 100; i++)
//* {
        //*body of the for..loop
//*     System.Console.WriteLine(i);
//* }

    System.Console.WriteLine("Please input a number...");
    int userInput = int.Parse(Console.ReadLine()!);
    for(int i = 0; i <= userInput; i++)
    {
        //we only want the odd values...
        if(i % 3 == 0)
        {
            System.Console.WriteLine(i);
        }
    }


//*  try
//*  {
//*      System.Console.WriteLine("Please input a number...");
//*      int userInput = int.Parse(Console.ReadLine()!);
//*      for(int i = 0; i <= userInput; i++)
//*      {
             //we only want the odd values...
//*          if(i % 3 == 0)
//*          {
//*              System.Console.WriteLine(i);
//*          }
//*      }
//*  }
//*  catch (Exception e)
//*  {
//*      System.Console.WriteLine(e.Message);
//*  }

