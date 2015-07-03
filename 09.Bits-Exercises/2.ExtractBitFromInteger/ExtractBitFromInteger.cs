using System;
/*
Write an expression that extracts from given integer n the value of given bit at index p. Examples:
n	    binary representation	p	    bit @ p
5	    00000000 00000101	    2	    1
0	    00000000 00000000   	9   	0
15  	00000000 00001111   	1   	1
5343	00010100 11011111   	7   	1
62241	11110011 00100001   	11	    0
 */
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Title = "Problem 2.	Extract Bit from Integer";
        Console.WriteLine("Enter integer n and index p.");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(n + " -> ");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        int nRightP = n >> p;
        Console.Write("{0}>>{1} -> ", n, p);
        Console.WriteLine(Convert.ToString(nRightP, 2).PadLeft(16, '0'));

        int bitP = nRightP & 1;
        Console.Write("({0}>>{1})&1 -> ", n, p);
        Console.WriteLine(Convert.ToString(bitP, 2).PadLeft(16, '0'));
        Console.WriteLine("bit at index P = {0}", bitP);
    }
}