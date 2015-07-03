using System;
using System.Linq;
using System.Collections.Generic;
class BullsAndCows
{
    const int Digits = 4;
    static void Main()
    {
        int secretNum = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool haveResult = false;
        for (int guessNum = 1111; guessNum <= 9999; guessNum++)
        {
            int bullsFound = GetBulls(secretNum, guessNum);
            int cowsFound = GetCows(secretNum, guessNum);
            if (bulls == bullsFound && cows == cowsFound)
            {
                if (guessNum.ToString().IndexOf('0') == -1)
                {
                    Console.Write(guessNum);
                    Console.Write(" ");
                    haveResult = true;
                }
            }
        }
        if (!haveResult)
        {
            Console.WriteLine("No");
        }
    }

    private static int GetBulls(int secretNum, int guessNum)
    {
        string secretNumber = secretNum.ToString().PadLeft(Digits, '0');
        string guessNumber = guessNum.ToString().PadLeft(Digits, '0');
        int bullsCount = 0;
        for (int i = 0; i < Digits; i++)
        {
            if (secretNumber[i] == guessNumber[i])
            {
                bullsCount++;
            }
        }
        return bullsCount;
        //char sec0 = secretNum.ToString()[0];
        //char sec1 = secretNum.ToString()[1];
        //char sec2 = secretNum.ToString()[2];
        //char sec3 = secretNum.ToString()[3];

        //char guess0 = guessNum.ToString()[0];
        //char guess1 = guessNum.ToString()[1];
        //char guess2 = guessNum.ToString()[2];
        //char guess3 = guessNum.ToString()[3];

        //int bullsCount = 0;
        //if(sec0 == guess0)
        //{
        //    bullsCount++;
        //}
        //if (sec1 == guess1)
        //{
        //    bullsCount++;
        //}
        //if (sec2 == guess2)
        //{
        //    bullsCount++;
        //}
        //if (sec3 == guess3)
        //{
        //    bullsCount++;
        //}
    }
    private static int GetCows(int secretNum, int guessNum)
    {
        List<char> secChars = new List<char>();
        for (int i = 0; i < Digits; i++)
        {
            int digit = secretNum % 10;
            string digitStr = "" + digit;
            char digitCh = digitStr[0];
            secChars.Insert(0, digitCh);
            secretNum /= 10;
        }

        List<char> guessChars = new List<char>();
        for (int i = 0; i < Digits; i++)
        {
            int digit = guessNum % 10;
            string digitStr = "" + digit;
            char digitCh = digitStr[0];
            guessChars.Insert(0, digitCh);
            guessNum /= 10;
        }

        for (int i = 0; i < Digits; i++)
        {
            if (guessChars[i] == secChars[i])
            {
                //We have a bull -> delete it
                guessChars[i] = '*';
                secChars[i] = '*';
            }
        }
        int cowsCount = 0;
        for (int secIndex = 0; secIndex < Digits; secIndex++)
        {
            for (int guessIndex = 0; guessIndex < Digits; guessIndex++)
            {
                if (secChars[secIndex] == guessChars[guessIndex]
                && secChars[secIndex] != '*')
                {
                    cowsCount++;
                    guessChars[guessIndex] = '*';
                    secChars[secIndex] = '*';
                }
            }
        }
        return cowsCount;
    }
}