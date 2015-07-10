using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magicSum = int.Parse(Console.ReadLine());
        magicSum = magicSum - 40;
        int magicCarNumbersCounter = 0;
        int[] u = new int[10];
        for (int i = 0; i < u.Length; i++)
        {
            u[0] = 10;
            u[1] = 20;
            u[2] = 30;
            u[3] = 50;
            u[4] = 80;
            u[5] = 110;
            u[6] = 130;
            u[7] = 160;
            u[8] = 200;
            u[9] = 240;
        }
        for (int ch1 = 0; ch1 <= 9; ch1++)
        {
            for (int ch2 = 0; ch2 <= 9; ch2++)
            {
                for (int carNum = 0; carNum <= 9999; carNum++)
                {
                    int i = carNum;
                    int A = i / 1000;
                    int B = i / 100 % 10;
                    int C = i / 10 % 10;
                    int D = i % 10;
                    if (A == B && B == C && C == D && (4 * A + u[ch1] + u[ch2] == magicSum))
                    {
                        magicCarNumbersCounter ++;
                    }
                    else if (A != B && B == C && C == D && (3 * B + A + u[ch1] + u[ch2] == magicSum))
                    {
                        magicCarNumbersCounter += 2;
                    }
                    else if (A == B && C == D && A != D && (2 * B + 2 * D + u[ch1] + u[ch2] == magicSum))
                    {
                        magicCarNumbersCounter += 3;
                    }
                }
            }
        }
        Console.WriteLine(magicCarNumbersCounter);
    }
}