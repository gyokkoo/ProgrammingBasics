using System;

class Bits
{
    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int xBitCounter = 0;
        for (int pos = 0; pos < 32; pos++)
        {
            for (int i = 1; i < 7; i++)
            {
                if (((numbers[i - 1] >> pos) & 7) == 5)
                {
                    if (((numbers[i] >> pos) & 7) == 2)
                    {
                        if (((numbers[i + 1] >> pos) & 7) == 5)
                        {
                            xBitCounter++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(xBitCounter);
    }
}