using System;
/*
 Write a program that reads a number n and prints on the console the first n members of the Fibonacci
 sequence (at a single line, separated by spaces) : 
 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
 Note that you may need to learn how to use loops.
 */
class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number n to see the first n members of the Fibonacci sequence");
        int integerN = int.Parse(Console.ReadLine());
        int fibonacciMemberX = 0;
        int fibonacciMemberOne = 0;
        int fibonacciMemberTwo = 1;
        if (integerN==0)
        {
            Console.Write("The number n cannot be 0!");
        }
        else if (integerN == 1)
        {
            Console.Write(0);
        }
        else
        {
            Console.Write("{0} {1} ", fibonacciMemberOne, fibonacciMemberTwo);
            for (int i = 2; i < integerN; i++)
            {
                fibonacciMemberX = fibonacciMemberOne + fibonacciMemberTwo;
                Console.Write("{0} ", fibonacciMemberX);
                fibonacciMemberOne = fibonacciMemberTwo;
                fibonacciMemberTwo = fibonacciMemberX;
            }
        }
        Console.WriteLine();
    }
}
