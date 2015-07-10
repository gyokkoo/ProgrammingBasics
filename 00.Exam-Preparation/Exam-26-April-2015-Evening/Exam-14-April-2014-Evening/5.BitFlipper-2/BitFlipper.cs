using System;

class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());

        for (int i = 61; i >= 0; i--)
        {
            ulong threeBits = (num >> i) & 7;
            if(threeBits == 0 || threeBits == 7)
            {
                num ^= (ulong)7 << i;
                i -= 2;
            }
        }

        Console.WriteLine(num);
    }
}
