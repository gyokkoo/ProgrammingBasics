using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        double totalPlays = hometownWeekends + ((48 - hometownWeekends) * 3 / 4.0) + holidays * 2 / 3.0;
        if (year == "leap")
        {
            totalPlays = totalPlays*1.15;
            Console.WriteLine(Math.Floor(totalPlays));
        }
        else if (year == "normal")
        {
            Console.WriteLine(Math.Floor(totalPlays));
        }
    }
}