using System;
/*
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 
Examples:
n	    binary representation	bit #3
5	    00000000 00000101	    0
0	    00000000 00000000   	0
15	    00000000 00001111   	1
5343	00010100 11011111	    1
 */
class ExtractBit3
{
    static void Main()
    {
        Console.Title = "Problem 1.	Bitwise: Extract Bit #3";
        Console.WriteLine("Enter unsigned integer.");
        Console.Write("n = ");

        uint n = uint.Parse(Console.ReadLine());
        Console.Write(n + " -> ");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        uint nRight3 = n >> 3;
        Console.Write("n>>3 -> ");
        Console.WriteLine(Convert.ToString(nRight3, 2).PadLeft(16, '0'));

        uint bit = nRight3 & 1;
        Console.Write("(n>>3)&1 -> ");
        Console.WriteLine(Convert.ToString(bit, 2).PadLeft(16, '0'));
        Console.WriteLine(bit);
    }
}