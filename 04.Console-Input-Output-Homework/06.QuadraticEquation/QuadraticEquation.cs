using System;
/*
 Write a program that reads the coefficients a, b and c of a quadratic equation 
 ax2 + bx + c = 0 and solves it (prints its real roots). Examples: 
 a	 b     c	roots
 2	 5	  -3	x1=-3; x2=0.5
-1	 3	   0	x1=3; x2=0
-0.5 4	  -8	x1=x2=4
 5	 2	   8	no real roots
 */
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("ax2 + bx + c = 0");
        Console.Write("Enter the coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        double discriminantD = Math.Sqrt(b * b - 4 * a * c);
        double firstRoot = (-b - discriminantD)/(2*a);
        double secondRoot = (-b + discriminantD)/(2*a);
        if(discriminantD==0)
        {
            Console.WriteLine("x1=x2={0}",firstRoot);
        }
        else if (discriminantD > 0)
        {
            Console.WriteLine("x1={0}; x2={1}", firstRoot, secondRoot);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}
