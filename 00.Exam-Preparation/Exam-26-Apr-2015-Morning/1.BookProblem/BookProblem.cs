using System;
class BookProblem
{
    static void Main()
    {
        double bookPage = int.Parse(Console.ReadLine());
        double campingDays = int.Parse(Console.ReadLine());
        double readingPerDay = int.Parse(Console.ReadLine());

        double normalDays = 30 - campingDays;
        if (normalDays <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double months = bookPage / (normalDays * readingPerDay);
            double yearsReading = months / 12;
            double monthsReading = months % 12;
            if (monthsReading == 0 && yearsReading == 0)
            {
                monthsReading = 1;
            }
            Console.WriteLine("{0} years {1} months", Math.Floor(yearsReading), Math.Ceiling(monthsReading));
        }
    }
}