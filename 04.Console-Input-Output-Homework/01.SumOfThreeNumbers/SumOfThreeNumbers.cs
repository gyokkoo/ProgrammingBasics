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
        int numberCount = 3;
        double[] numbers = new double[numberCount];
        double sum = 0;
        Console.WriteLine("Please enter three real numbers, each in separated line, to see their sum.");
        for (int i = 0; i < numberCount; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum = sum + numbers[i];
        }
        Console.WriteLine("The sum is: {0}", sum);  
    }
}

