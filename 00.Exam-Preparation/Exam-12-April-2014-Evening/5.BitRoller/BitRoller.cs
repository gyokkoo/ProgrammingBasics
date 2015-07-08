using System;

class BitRoller
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int frozenBit = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        frozenBit = 18 - frozenBit;

        char[] bits = Convert.ToString(number,2).PadLeft(19, '0').ToCharArray();

        // Console.WriteLine(new string(bits));
        for (int i = 0; i < r; i++)
        {
            RollBitsRight(bits, frozenBit);
        }

        int result = Convert.ToInt32(new string(bits), 2);
        Console.WriteLine(result);
    }
    static void RollBitsRight(char[] bits, int frozenBit)
    {
        char[] newBits = new char[19];
        for (int pos = 0; pos < 19; pos++)
        {
            if(pos == frozenBit)
            {
                newBits[pos] = bits[pos];
            }
            else
            {
                int newPos = (pos + 1) % 19;
                if(newPos == frozenBit)
                {
                    newPos = (newPos + 1) % 19;
                }
                newBits[newPos] = bits[pos];
            }
        }

        for (int i = 0; i < 19; i++)
        {
            bits[i] = newBits[i];
        }
    }
}