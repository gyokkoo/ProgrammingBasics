using System;
/*
Write a program that finds the biggest of five numbers by using only five if statements. Examples:
a	b	c	d	e	biggest
5	2	2	4	1	5
-2	-22	1	0	0	1
-2	4	3	2	0	4
 */ 
class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 6.	The Biggest of Five Numbers";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        if (a>b && a>c && a>d && a>e)
        {
            Console.WriteLine("The biggest is {0}", a);
        }
        if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest is {0}", b);
        }
        if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest is {0}", c);
        }
        if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The biggest is {0}", d);
        }
        if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("The biggest is {0}", e);
        }
        else
        {
            Console.WriteLine("The biggest is {0}", Math.Max(Math.Max(Math.Max((Math.Max(a, b)), c), d), e)); //if we have equal biggest numbers
        }
    }
}