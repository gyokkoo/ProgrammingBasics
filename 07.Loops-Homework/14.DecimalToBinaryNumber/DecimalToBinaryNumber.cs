using System;
/*
Using loops write a program that converts an integer number to its binary representation. The input is entered as long. 
The output should be a variable of type string. Do not use the built-in .NET functionality. 
Examples:
decimal 	binary
0	        0
3	        11
43691   	1010101010101011
 */
class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Title = "Problem 14.	Decimal to Binary Number";
        Console.WriteLine("Enter integer decimal number.");
        Console.Write("decimal = ");
        long decimalNumber = long.Parse(Console.ReadLine());
        long remainder;
        string binaryNumber = string.Empty;
        if (decimalNumber == 0)
        {
            Console.WriteLine("binary = 0");
        }
        else
        {
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binaryNumber = remainder.ToString() + binaryNumber;
            }
            Console.WriteLine("binary = {0}", binaryNumber);
        }
    }
}