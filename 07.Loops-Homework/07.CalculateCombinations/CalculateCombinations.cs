using System;
using System.Numerics;
class CalculateCombinations
{
    static void Main()
    {
        Console.Title = "Problem 7.	Calculate N! / (K! * (N-K)!)";
        Console.WriteLine("Enter two integers n and k (1<k<n<100).");
        Console.Write("n = ");
        double n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        double k = double.Parse(Console.ReadLine());
        double factorialN = 1;
        double factorialK = 1;
        double factorailNminusK = 1;
        double difference = n - k;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if ((i + difference) <= n)
            {
                factorialK *= i;
            }
        }
        for (int i = 1; i <= difference; i++)
        {
            factorailNminusK *= i;
        }
        double combinations = factorialN / (factorialK * (factorailNminusK));
        Console.WriteLine(combinations);
    }
}