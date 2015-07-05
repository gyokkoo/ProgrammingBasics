using System;
/*
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
n	IsPrime(n)
0	false
1	false
2	true
3	true
4	false
5	true
323	false
 */
class PrimeChecker
{
    static void Main()
    {
        Console.Title = "Problem 2.	Prime Checker";
        Console.WriteLine("Enter integer number n.");
        Console.Write("n = ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Is {0} prime? --> {1} <--", number, isPrime(number));
    }
    static bool isPrime(long number)
    {
        bool isPrime = true;
        if (number == 0 || number == 1)
        {
            isPrime = false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
            {
                isPrime = false;
            }
        }
        return isPrime;
    }
}