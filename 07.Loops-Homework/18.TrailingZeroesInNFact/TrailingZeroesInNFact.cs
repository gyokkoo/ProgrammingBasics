using System;
using System.Numerics;
/*
Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
Your program should work well for very big numbers, e.g. n=100000. Examples:
n	trailing zeroes of n!	explaination
10	2	3628800
20	4	2432902008176640000
 */
class TrailingZeroesInNFact
{
    static void Main()
    {
        Console.Title = "Problem 18.	* Trailing Zeroes in N!";
        Console.WriteLine("Enter integer n.");
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int trailingZeroes = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            if (factorial % 10 == 0)
            {
                trailingZeroes++;
                factorial /= 10;
            }
        }
        Console.WriteLine("trailing zeroes of n! = {0}", trailingZeroes);
    }
}