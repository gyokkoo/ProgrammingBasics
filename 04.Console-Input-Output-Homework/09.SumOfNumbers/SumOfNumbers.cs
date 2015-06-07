using System;
/*
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
Note that you may need to use a for-loop. Examples:
numbers	sum   
3
20
60
10	   90
*/
class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number n and n numbers to see their sum.");
        int integerN = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0 ; i < integerN; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of entered numbers is: {0}", sum);
    }
}
