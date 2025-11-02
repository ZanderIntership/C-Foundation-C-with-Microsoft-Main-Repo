
using System.Diagnostics.Metrics;

int Length = 99;


for (int I = 1; I < Length; I++)
{

    if (I % 3 == 0 && I % 5 == 0)
    {
        Console.WriteLine($"{I} - FizzBuzz");
       
    } else if (I % 5 == 0)
    {
        Console.WriteLine($"{I} - Buzz");
      
    } else if (I % 3 == 0)
    {
        Console.WriteLine($"{I} - Fizz");

    }
    else
    {
        Console.WriteLine(I);
    }



}
