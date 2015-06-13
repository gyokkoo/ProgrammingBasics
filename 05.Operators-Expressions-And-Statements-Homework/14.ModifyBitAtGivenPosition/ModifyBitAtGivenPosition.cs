using System;
/*
We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. Examples:
n	binary representation of n	p	v	binary result	    result
5	00000000 00000101    	    2	0	00000000 00000001	1
0	00000000 00000000        	9	1	00000010 00000000	512
15	00000000 00001111        	1	1	00000000 00001111	15
 */
class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n, bit value (0 or 1) and poition p");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("v=");
        int v = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            v = 1;
        }
        else
        {
            v = 0;
        }
        Console.WriteLine("Binary representation of n");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        int mask = ~(v << p);
        int result = n & mask;
        Console.WriteLine("Binary result:");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine(result);
    }
}

