using System;
/*
 Write an expression that checks if given integer is odd or even. 
 Examples:
n	Odd?
3	true
2	false
-2	false
-1	true
0	false
 */
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter integer n to see if it is odd");
        int integerN = int.Parse(Console.ReadLine());
        Console.WriteLine(integerN % 2 == 1 ? "true" : "false");
    }
}