using System;
/*
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
Use only one loop. Print the result with 5 digits after the decimal point.
n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781
 */
class CalculateTheSum
{
    static void Main()
    {
        Console.Title = "Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN";
        Console.WriteLine("Enter two integer numbers n and x.");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int factorial = 1;
        double sum = 1;
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / (Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
