using System;

class FourFactors
{
    static void Main()
    {
        decimal FG = decimal.Parse(Console.ReadLine());
        decimal FGA = decimal.Parse(Console.ReadLine());
        decimal ThreeP = decimal.Parse(Console.ReadLine());
        decimal TOV = decimal.Parse(Console.ReadLine());
        decimal ORB = decimal.Parse(Console.ReadLine());
        decimal OppDRB = decimal.Parse(Console.ReadLine());
        decimal FT = decimal.Parse(Console.ReadLine());
        decimal FTA = decimal.Parse(Console.ReadLine());

        decimal eFGfactor = (FG + 0.5m * ThreeP) / FGA;
        decimal TOVfactor = TOV / (FGA + 0.44m * FTA + TOV);
        decimal ORBfactor = ORB / (ORB + OppDRB);
        decimal FTfactor = FT / FGA;

        Console.WriteLine("eFG% {0:F3}", eFGfactor);
        Console.WriteLine("TOV% {0:F3}", TOVfactor);
        Console.WriteLine("ORB% {0:F3}", ORBfactor);
        Console.WriteLine("FT% {0:F3}", FTfactor);
    }
}