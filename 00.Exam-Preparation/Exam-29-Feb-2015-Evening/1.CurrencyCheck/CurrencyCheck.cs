using System;
class CurrencyCheck
{
    static void Main()
    {
        double rubles = double.Parse(Console.ReadLine());
        double dollars = double.Parse(Console.ReadLine());
        double euros = double.Parse(Console.ReadLine());
        double levasForTwo = double.Parse(Console.ReadLine());
        double levasForOne = double.Parse(Console.ReadLine());

        double rublesInLeva = (rubles/100.0)*3.5;
        double dollarsInLeva = dollars * 1.5;
        double eurosInLeva = euros * 1.95;
        double firstSiteInLeva = levasForTwo / 2;

        double min = Math.Min(levasForOne, Math.Min(firstSiteInLeva,Math.Min(eurosInLeva, Math.Min(rublesInLeva, dollarsInLeva))));
        Console.WriteLine("{0:F2}", min);
    }
}
