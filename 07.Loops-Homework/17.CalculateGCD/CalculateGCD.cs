using System;
/*
Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
Use the Euclidean algorithm (find it in Internet). Examples:
a	b	GCD(a, b)
3	2	1
60	40	20
5	-15	5
 */
class CalculateGCD
{
    static void Main()
    {
        Console.Title = "Problem 17.	* Calculate GCD";
        Console.WriteLine("Enter two integers a and b.");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if (a<b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        int divisor = (a % b);
        while (divisor !=0)
        {
            a = b;
            b = divisor;
            divisor = a % b;
        }
        Console.WriteLine("GCD(a,b) = {0}", b);
    }
}