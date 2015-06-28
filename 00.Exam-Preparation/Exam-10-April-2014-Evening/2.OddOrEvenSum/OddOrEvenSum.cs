using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 1; i <= 2*n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 1)
            {
                sumOdd += number;
            }
            else
            {
                sumEven += number;
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("Yes, sum={0}", sumEven);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumEven-sumOdd));
        }
    }
}