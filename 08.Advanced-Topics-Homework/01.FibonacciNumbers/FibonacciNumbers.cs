using System;
/*
Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
n	Fib(n)
0	1
1	1
2	2
3	3
4	5
5	8
6	13
11	144
25	121393
 */
class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Problem 1.	Fibonacci Numbers";
        Console.WriteLine("Enter nth Fibonacci Number.");
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine("{0} Fibonacci Number is -> {1}", n, Fib(n));
    }
    static long Fib(long n)
    {
        if (n == 0 || n == 1) return 1;
        if (n == 2) return 2;
        else
        {
            long f1 = 1;
            long f2 = 2;
            long f3;
            long result = 0;
            for (int i = 0; i < n - 2; i++)
            {
                f3 = f1 + f2;
                result = f3;
                f1 = f2;
                f2 = f3;
            }
            return result;
        }
    }
}