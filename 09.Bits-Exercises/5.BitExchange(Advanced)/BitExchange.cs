using System;
/*
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
The first and the second sequence of bits may not overlap. Examples: 
 */
class BitExchange
{
    static void Main()
    {
        Console.Title = "Problem 5.** Bit Exchange (Advanced)";
        Console.Write("n= ");
        uint n = uint.Parse(Console.ReadLine());

        Console.Write("p= ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("q= ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of {0} is: {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        for (int i = p; i <= p + k - 1; i++)
        {
            uint mask = 1; // 0111
            uint bitQ = (n & (mask << q)) >> q;
            uint bitP = (n & (mask << i)) >> i;
            n = n & ~(mask << i); //nullify
            n = n & ~(mask << q); //nullify
            n = n | (bitQ << i); //change bit p
            n = n | (bitP << q); //change bit q            
            q++;
        }
        Console.WriteLine("Binary representation of {0} is: {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}
