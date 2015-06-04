using System;
class CompoundInterest
{
    static void Main()
    {
        double tvPrice = double.Parse(Console.ReadLine());
        int bankLoanTerm = int.Parse(Console.ReadLine());
        double bankInterest = double.Parse(Console.ReadLine());
        double friendInterest = double.Parse(Console.ReadLine());

        double bankAmount = tvPrice * Math.Pow((1 + bankInterest), bankLoanTerm);
        double friendAmount = tvPrice * (1 + friendInterest);
        if (bankAmount < friendAmount)
        {
            Console.WriteLine("{0:F2} Bank", bankAmount);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendAmount);
        }
    }
}