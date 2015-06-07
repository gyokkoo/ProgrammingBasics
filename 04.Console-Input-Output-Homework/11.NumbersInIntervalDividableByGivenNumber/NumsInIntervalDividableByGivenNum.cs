using System;
/*
Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
such that the reminder of the division by 5 is 0. 
 */
class NumsInIntervalDividableByGivenNum
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integers for interval. (each on separate line)");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int counterP = 0;
        for (int i = start; i <= end; i++)
        {
            if (i%5==0)
            {
                counterP++;
            }
        }
        Console.WriteLine("{0} numbers between {1} and {2} are divided by 5", counterP, start, end);
    }
}