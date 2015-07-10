using System;

class TravellerBob
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int monthsInContracts = int.Parse(Console.ReadLine());
        int monthsWithFamily = int.Parse(Console.ReadLine());
        int normalMonths = 12- monthsWithFamily - monthsInContracts;

        double contractTravels = 12.0 * monthsInContracts;
        double familyTravels = 4.0 * monthsWithFamily;
        double normalMonthsTravels = 12.0 * normalMonths * 0.6;

        double allTravels = contractTravels + familyTravels + normalMonthsTravels;

        if(yearType == "leap")
        {
            allTravels = allTravels * 1.05;
        }

        Console.WriteLine("{0}", (int)allTravels);
    }
}
