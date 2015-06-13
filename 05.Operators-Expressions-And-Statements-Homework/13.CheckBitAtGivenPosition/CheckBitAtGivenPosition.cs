using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer n and see if the bit at position p has value 1");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine("The integer n in p position right:");
        Console.WriteLine(Convert.ToString(nRightP, 2).PadLeft(16, '0'));
        bool bitAtPositionP = bit == 1;
        Console.WriteLine("bit @p == 1 -> {0}", bitAtPositionP);
    }
}
