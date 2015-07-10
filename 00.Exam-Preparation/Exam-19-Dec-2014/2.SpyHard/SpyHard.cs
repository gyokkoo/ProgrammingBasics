using System;

class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        int messageSum = 0;

        char[] ch = message.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] >= 'A' && ch[i] <= 'Z')
            {
                messageSum += ((int)ch[i] - 64);
            }
            else if (ch[i] >= 'a' && ch[i] <= 'z')
            {
                messageSum += ((int)ch[i] - 96);
            }
            else
            {
                messageSum += (int)ch[i];
            }
        }
        string systemNum = "";
        if(key == 2 || key == 10)
        {
            systemNum = Convert.ToString(messageSum, key);
        }
        else 
        {
            systemNum = DecimalToArbitrarySystem(messageSum, key);
        }
    
        string output = (key + "") + (message.Length + "") + systemNum;
        Console.WriteLine(output);
    }
    public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
    {
        const int BitsInLong = 64;
        const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (radix < 2 || radix > Digits.Length)
            throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

        if (decimalNumber == 0)
            return "0";

        int index = BitsInLong - 1;
        long currentNumber = Math.Abs(decimalNumber);
        char[] charArray = new char[BitsInLong];

        while (currentNumber != 0)
        {
            int remainder = (int)(currentNumber % radix);
            charArray[index--] = Digits[remainder];
            currentNumber = currentNumber / radix;
        }

        string result = new String(charArray, index + 1, BitsInLong - index - 1);
        if (decimalNumber < 0)
        {
            result = "-" + result;
        }

        return result;
    }
}