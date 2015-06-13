using System;
/*
Write an expression that calculates trapezoid's area by given sides a and b and height h. 
Examples:
a	b	h	area	 
5	7	12	72	
2	1	33	49.5	
8.5	4.3	2.7	17.28	
100	200	300	45000	
0.222	0.333	0.555	0.1540125	
 */
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter side a and b and height h of trapezoid to see its area");
        Console.Write("a=");
        double sideA = double.Parse(Console.ReadLine()); 
        Console.Write("b=");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("h=");
        double heightH = double.Parse(Console.ReadLine());
        double area = (sideA + sideB) * heightH / 2;
        Console.WriteLine("The trapezoid's area is {0}", area);
    }
}
