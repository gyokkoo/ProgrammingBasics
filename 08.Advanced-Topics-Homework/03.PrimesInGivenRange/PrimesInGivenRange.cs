using System;
using System.Collections.Generic;
/*
Write a method that calculates all prime numbers in given range and returns them as list of integers:
Write a method to print a list of integers. Write a program that enters two integer numbers 
and prints all primes in their range, separated by a comma.
 */
class PrimesInGivenRange
{
    static void Main()
    {
        Console.Title = "Problem 3.	Primes in Given Range";
        Console.WriteLine("Enter start number and end number.");
        Console.Write("Start number = ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("End number = ");
        int endNum = int.Parse(Console.ReadLine());
        if (startNum > endNum)
        {
            Console.WriteLine("Empty list");
        }
        else
        {
            foreach (int prime in FindPrimesInRange(startNum, endNum))
            {
                Console.Write("{0}, ", prime);
            }
            Console.WriteLine();
        }
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> Primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (i == 0 || i== 1)
            {
                continue;
            }
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Primes.Add(i);
            }
        }
        return Primes;
    }
}
