using System;
/*
Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
without calculating it. 
Use a sequence of if operators. 
Examples:
a	b	    c	result
5	2	    2	+
-2	-2   	1	+
-2	4    	3	-
0	-2.5	4	0
 */
class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.Title = "Problem 4.	Multiplication Sign";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The result is 0");
        }
        else if ((a < 0 && b < 0 && c < 0) || (a < 0 ^ b < 0 ^ c < 0))
        {
            Console.WriteLine("The multiplication sign is -");
        }
        else if ((a > 0 && b > 0 && c > 0) || (a > 0 ^ b < 0 ^ c < 0))
        {
            Console.WriteLine("The multiplication sign is +");
        }
    }
}
