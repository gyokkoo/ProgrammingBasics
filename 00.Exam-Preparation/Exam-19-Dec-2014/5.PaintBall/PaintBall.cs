using System;
using System.Collections.Generic;

class PaintBall
{
    static void Main()
    {
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = 1023;
        }

        string shot = Console.ReadLine();
        bool isBlack = true;

        do
        {
            int radius = int.Parse(shot.Substring(4));
            int row = int.Parse(shot[0].ToString());
            int bitPos = int.Parse(shot[2].ToString());
            
            for (int i = GetStartPos(row,radius); i <= GetEndPos(row, radius, numbers.Length); i++)
            {
                if(isBlack)
                {
                    for (int j = GetStartPos(bitPos, radius); j <= GetEndPos(bitPos, radius, numbers.Length) ; j++)
                    {
                        numbers[i] &= ~(1 << j);
                    }
                }
                else
                {
                    for (int j = GetStartPos(bitPos, radius); j <= GetEndPos(bitPos, radius, numbers.Length); j++)
                    {
                        numbers[i] |= (1 << j);
                    }
                }
            }
            isBlack = !isBlack;
            shot = Console.ReadLine();
        } while (shot != "End");

        int sum = 0;
        for (int row = 0; row < numbers.Length; row++)
        {
            sum += numbers[row];
        }
        Console.WriteLine(sum);
    }
    static int GetStartPos(int n, int radius)
    {
        return n - radius >= 0 ? n - radius : 0; 
    }
    static int GetEndPos(int n, int radius, int length)
    {
        return n + radius < length ? n + radius : length - 1;
    }
}