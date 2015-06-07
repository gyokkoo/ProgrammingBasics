using System;
/*
Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
each on a single line. Note that you may need to use a for-loop. Examples:
*/
class NumbersFrom1ToN
{
    static void Main ()
    {
        Console.WriteLine("Please, enter an integer number n to see all numbers in the interval [1..n]");
        int integerN = int.Parse(Console.ReadLine());
        for (int i = 1; i <= integerN; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
