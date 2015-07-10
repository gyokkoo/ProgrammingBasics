using System;

class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        string numAsString = Convert.ToString((long)num, 2).PadLeft(64, '0');

        char[] numAsChar = numAsString.ToCharArray();
        for (int i = 2; i < 64; i++)
        {
            if (numAsChar[i] == numAsChar[i - 1] && numAsChar[i] == numAsChar[i - 2])
            {
                if (numAsChar[i] == '0')
                {
                    numAsChar[i] = '1';
                    numAsChar[i - 1] = '1';
                    numAsChar[i - 2] = '1';
                }
                else if (numAsChar[i] == '1')
                {
                    numAsChar[i] = '0';
                    numAsChar[i - 1] = '0';
                    numAsChar[i - 2] = '0';
                }
                i += 2;
            }
        }
        num = Convert.ToUInt64(new string(numAsChar),2);
        Console.WriteLine(num);
    }
}
