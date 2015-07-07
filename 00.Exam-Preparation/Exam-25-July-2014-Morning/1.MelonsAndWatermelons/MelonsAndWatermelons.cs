using System;
class Program
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int waterMelon = 0;
        int melon = 0;

        int monday = 1;
        int tuesday = 2;
        int wednesday = 3;
        int thursday = 4;
        int friday = 5;
        int saturday = 6;

        int sd = s + d;
        for (int i = s; i < sd; i++)
        {
            if (i % 7 == monday) { waterMelon += 1; }
            if (i % 7 == tuesday) { melon += 2; }
            if (i % 7 == wednesday) { melon += 1; waterMelon += 1; }
            if (i % 7 == thursday) { waterMelon += 2; }
            if (i % 7 == friday) { melon += 2; waterMelon += 2; }
            if (i % 7 == saturday) { waterMelon += 1; melon += 2; }
        }

        if (waterMelon > melon)
        {
            Console.WriteLine("{0} more watermelons", waterMelon - melon);
        }
        else if (waterMelon < melon)
        {
            Console.WriteLine("{0} more melons", melon - waterMelon);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melon);
        }
    }
}