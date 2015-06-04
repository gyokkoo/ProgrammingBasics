using System;
/*
  Write a program that reads 3 real numbers from the console and prints their sum.
a	b	c	  sum
3	4	11	  18
-2	0	3	  1
5.5	4.5	20.1  30.1

*/
class SumOfThreeNumbers
{
    static void Main()
    {
        //declaring 3 reals numbers from the console.
        Console.Write("a=");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double thirdNumber = double.Parse(Console.ReadLine());
        //Printing their sum.
        Console.WriteLine("The sum is: {0}", firstNumber + secondNumber + thirdNumber);
    }
}

