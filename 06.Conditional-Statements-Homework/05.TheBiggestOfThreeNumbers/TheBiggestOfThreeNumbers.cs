using System;
/*
Write a program that finds the biggest of three numbers. Examples:
a	b	c	biggest
5	2	2	5
-2	-2	1	1
-2	4	3	4
 */
class TheBiggestOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 5.	The Biggest of 3 Numbers";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("The biggest is {0}", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("The biggest is {0}", b);
        }
        else if (c > a && c > b) 
        {
            Console.WriteLine("The biggest is {0}", c);
        }
        else
        {
            Console.WriteLine("The biggest is {0}", Math.Max(Math.Max(a, b), c)); //if we have equal biggest numbers
        }
    }
}
