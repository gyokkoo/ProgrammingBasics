using System;
/*
We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators 
that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
Examples:
n   	binary representation of n	p	v	binary result	    result
5	    00000000 00000101       	2	0	00000000 00000001	1
0   	00000000 00000000	        9	1	00000010 00000000	512
15	    00000000 00001111       	1	1	00000000 00001111	15
5343	00010100 11011111	        7	0	00010100 01011111	5215
62241	11110011 00100001	        11	0	11110011 00100001	62241
 */
class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Title = "Problem 3.	Modify a Bit at Given Position";
        Console.WriteLine("Enter integer n, position p, and v (0 or 1).");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("{0} -> ", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            v = 1;
        }
        else if (v == 1)
        {
            v = 0;
        }

        int mask = ~(v << p);
        int result = n & mask;
        Console.Write("n & ~({1}<<{0}) -> ", p, v);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine("result = " + result);

    }
}
