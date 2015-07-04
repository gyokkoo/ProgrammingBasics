using System;
class TorrentPirate
{
    static void Main()
    {
        double downloadData = double.Parse(Console.ReadLine());
        double cinemaCost = double.Parse(Console.ReadLine());
        double wifeSpending = double.Parse(Console.ReadLine());


        double downloadTime = downloadData / 2 / 60 / 60;
        double downloadPrice = downloadTime * wifeSpending;
        double movies = downloadData / 1500;
        double cinemaPrice = movies * cinemaCost;

        if (cinemaPrice < downloadPrice)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", downloadPrice);
        }
    }
}
