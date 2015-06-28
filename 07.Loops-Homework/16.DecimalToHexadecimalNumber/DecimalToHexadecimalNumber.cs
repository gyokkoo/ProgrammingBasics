using System;
/*
Using loops write a program that converts an integer number to its hexadecimal representation. 
The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. Examples: 
decimal	hexadecimal
254   	FE
6883	1AE3
*/
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Title = "Problem 16.	Decimal to Hexadecimal Number";
        Console.WriteLine("Enter integer number.");
        Console.Write("decimal = ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string hexadecimalNumber = "";
        while (decimalNumber != 0)
        {
            if((decimalNumber%16) < 10)
            {
                hexadecimalNumber = decimalNumber % 16 + hexadecimalNumber;
            }
            else
            {
                string temp = "";
                switch(decimalNumber % 16)
                {
                    case 10: temp = "A"; break;
                    case 11: temp = "B"; break;
                    case 12: temp = "C"; break;
                    case 13: temp = "D"; break;
                    case 14: temp = "E"; break;
                    case 15: temp = "F"; break;
                }
                hexadecimalNumber = temp + hexadecimalNumber;
            }
            decimalNumber /= 16;
        }
        Console.WriteLine("hexadecimal = {0}", hexadecimalNumber);
    }
}
