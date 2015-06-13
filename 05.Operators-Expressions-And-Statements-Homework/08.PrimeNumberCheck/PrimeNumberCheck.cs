using System;
/*
 Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
 (i.e. it is divisible without remainder only to itself and 1). Examples:
n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
 */
class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter integer n to see if it is prime");
        Console.Write("n=");
        int integerN = int.Parse(Console.ReadLine());
        bool isPrime;
        int count = 0; 
        for (int i = 2; i < integerN; i++)
        {
            if (integerN % i != 0)
            {
                count++;
            }
        }
        isPrime = count + 2 == integerN ? true : false;
        Console.WriteLine(isPrime);
    }
}
