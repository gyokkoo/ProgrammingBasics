using System;
/*
Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. Examples:
a	b	c	result
5	1	2	5 2 1
-2	-2	1	1 -2 -2
-2	4	3	4 3 -2

 */
class SortThreeNumbers
{
    static void Main()
    {
        Console.Title = "Problem 7.	Sort 3 Numbers with Nested Ifs";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Before sorting  -> {0} {1} {2}", a, b, c);
        if (a>=b && a>=c)
        {
            if (b>=c)
            {
                Console.WriteLine("In sorted order -> {0} {1} {2}", a, b, c);
            }
            else if(c>=b)
            {
                Console.WriteLine("In sorted order -> {0} {1} {2}", a, c, b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("In sorted order -> {0} {1} {2}", b, a, c);
            }
            else if (c >= a)
            {
                Console.WriteLine("In sorted order -> {0} {1} {2}", b, c, a);
            }
        }
        else if (c >= a && c >= b)
        {
            if (a >= b)
            {
                Console.WriteLine("In sorted order -> {0} {1} {2}", c, a, b);
            }
            else if (b >= a)
            {
                Console.WriteLine("In sorted order -> {0} {1} {2}", c, b, a);
            }
        }
    }
}    
