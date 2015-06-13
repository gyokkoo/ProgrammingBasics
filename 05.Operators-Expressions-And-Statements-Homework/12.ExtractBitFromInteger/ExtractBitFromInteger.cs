using System;
/*
Problem 12.	Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p. Examples:
n	binary representation	p	bit @ p
5	00000000 00000101	    2	1
0	00000000 00000000	    9	0
15	00000000 00001111	    1	1
 
 */
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter integer n and bit at index p to see its value");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        Console.WriteLine("The integer n in p position right:");
        Console.WriteLine(Convert.ToString(nRightP, 2).PadLeft(16, '0'));
        int bit = nRightP & 1;
        Console.WriteLine("The valie of bit at index p is {0}", bit);
    }
}

