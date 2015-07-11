using System;

class BitRoller
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int rolls = int.Parse(Console.ReadLine());

        int bitsLenght = 19;
        int fixedBitMask = number & (1 << f) >> f;
        int shiftedFixedBitMask;
        //  Console.WriteLine(Convert.ToString(number, 2));

        for (int i = 0; i < rolls; i++)
        {
            if (f == 0)
            {
                number = (number >> 1) | fixedBitMask;
            }
            else
            {
                int firstBitValue = number & 1;

                if (f != (bitsLenght - 1))
                {
                    shiftedFixedBitMask = (number & (1 << (f + 1))) >> (f + 1);
                }
                else
                {
                    shiftedFixedBitMask = (number & 1);
                }

                number = ((number >> 1) | (firstBitValue << (bitsLenght - 1)));

                if (fixedBitMask == 0)
                {
                    number = number & (~(1 << f));
                }
                else
                {
                    number = number | (1 << f);
                }

                if (shiftedFixedBitMask == 0)
                {
                    number = number & (~(1 << (f - 1)));
                }
                else
                {
                    number = number | (1 << (f - 1));
                }
                //Console.WriteLine(Convert.ToString(number, 2));
            }
        }

        Console.WriteLine(number);
    }
}

