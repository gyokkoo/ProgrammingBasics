using System;
using System.Numerics;
public class PetarsGame
{
    public static void Main()
    {
        ulong start = ulong.Parse(Console.ReadLine());
        ulong end = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        BigInteger sum = 0;
        for (ulong i = start; i < end; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += i % 5;
            }
        }
        string sumString = sum.ToString();
        string digitToReplace;
        if (sum % 2 == 0)
        {
            digitToReplace = sumString[0].ToString();
        }
        else
        {
            digitToReplace = sumString[sumString.Length - 1].ToString();
        }
        sumString = sumString.Replace(digitToReplace, replacement);
        Console.WriteLine(sumString);
    }
}