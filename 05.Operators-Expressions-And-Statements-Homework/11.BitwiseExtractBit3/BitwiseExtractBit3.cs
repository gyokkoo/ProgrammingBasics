using System;
/*
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
Examples:
n	binary representation	bit #3
5	00000000 00000101    	0
0	00000000 00000000	    0
15	00000000 00001111    	1 
 */
class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter unsigned integer n to see the value of the bit #3");
        Console.Write("n=");
        int integerN = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(integerN, 2).PadLeft(16, '0'));
        int nRight3 = integerN >> 3;
        Console.WriteLine("The integer n in three position right:");
        Console.WriteLine(Convert.ToString(nRight3, 2).PadLeft(16, '0'));
        int bit = nRight3 & 1;
        Console.WriteLine("The value of bit #3 is {0}", bit);
    }
}

