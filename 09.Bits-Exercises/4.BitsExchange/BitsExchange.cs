using System;
/*
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. Examples:
 */
class BitsExchange
{
    static void Main()
    {
        Console.Title = "Problem 4. 	* Bits Exchange";
        Console.WriteLine("Enter unsigned integer.");
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine();

        uint mask = 7; // 01111
        uint firstBits = (n & (mask << 3)) >> 3; //Take bits 3 4 5, and then they go back  to the beginning
        uint secondBits = (n & (mask << 24)) >> 24; //Take bits 24 25 26, and then they go back to the beginning 

        n = n & ~(mask << 3);
        n = n & ~(mask << 24);
        n = n | (firstBits << 24);
        n = n | (secondBits << 3);
        Console.WriteLine("result = " + n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

    }
}
