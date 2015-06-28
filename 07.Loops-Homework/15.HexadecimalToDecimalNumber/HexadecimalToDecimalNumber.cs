using System;
using System.Linq;
/*
Using loops write a program that converts a hexadecimal integer number to its decimal form. 
The input is entered as string. The output should be a variable of type long. 
Do not use the built-in .NET functionality. Examples:
hexadecimal 	decimal
FE	            254
1AE3	        6883
 */
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Title = "Problem 15.	Hexadecimal to Decimal Number";
        Console.WriteLine("Enter hexadecimal integer number.");
        Console.Write("hexadecimal = ");
        string hexadecimalNumber = Console.ReadLine();
        long decimalNumber = 0;
        int len = hexadecimalNumber.Length;
        int[] array = new int[len];
        for (int i = len - 1; i >= 0; i--)
        {
            int numChar = hexadecimalNumber[i];
            switch (numChar)
            {
                case 'A': array[len - i - 1] = 10; break;
                case 'B': array[len - i - 1] = 11; break;
                case 'C': array[len - i - 1] = 12; break;
                case 'D': array[len - i - 1] = 13; break;
                case 'E': array[len - i - 1] = 14; break;
                case 'F': array[len - i - 1] = 15; break;
                case '0': array[len - i - 1] = 0; break;
                case '1': array[len - i - 1] = 1; break;
                case '2': array[len - i - 1] = 2; break;
                case '3': array[len - i - 1] = 3; break;
                case '4': array[len - i - 1] = 4; break;
                case '5': array[len - i - 1] = 5; break;
                case '6': array[len - i - 1] = 6; break;
                case '7': array[len - i - 1] = 7; break;
                case '8': array[len - i - 1] = 8; break;
                case '9': array[len - i - 1] = 9; break;
                default: break;
            }
        }
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            decimalNumber += (long)(array[i] * Math.Pow(16, i));
        }
        Console.WriteLine("decimal = {0}", decimalNumber);
    }
}