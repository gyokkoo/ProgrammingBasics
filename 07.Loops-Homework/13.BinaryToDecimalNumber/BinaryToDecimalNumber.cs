using System;
using System.Linq;
/*
Using loops write a program that converts a binary integer number to its decimal form. 
The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:
binary          	decimal
0	                0
11	                3
1010101010101011	43691
 
 */
class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Title = "Problem 13.	Binary to Decimal Number";
        Console.WriteLine("Enter binary integer number.");
        Console.Write("binary = ");
        string binaryNumber = Console.ReadLine();  
        long decimalNumber = 0;
        long[] array = binaryNumber.Select(x => long.Parse(x.ToString())).ToArray();
        Array.Reverse(array);
        for (int i = 0 ; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                decimalNumber += (long)Math.Pow(2, i);
            }
        }
        Console.WriteLine("decimal = {0}",decimalNumber);
    }
}
