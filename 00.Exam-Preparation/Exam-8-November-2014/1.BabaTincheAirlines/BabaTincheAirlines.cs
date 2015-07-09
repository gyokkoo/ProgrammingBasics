using System;

class BabaTincheAirlines
{
    static void Main()
    {
        string firstClassInput = Console.ReadLine();
        string[] firstClassInfo = firstClassInput.Split(' ');
        int firstClassPassengers = int.Parse(firstClassInfo[0]);
        int firstClassFrequentFlyers = int.Parse(firstClassInfo[1]);
        int firstClassMealPurchase = int.Parse(firstClassInfo[2]);

        decimal firstClassIncome = (firstClassFrequentFlyers * 2100M) +
            (firstClassPassengers - firstClassFrequentFlyers) * 7000M + 
            (firstClassMealPurchase * (0.005M * 7000M));
        decimal firstClassMaxIncome = 12*7000*1.005M;


        string businessClassInput = Console.ReadLine();
        string[] businessClassInfo = businessClassInput.Split(' ');
        int businessClassPassengers = int.Parse(businessClassInfo[0]);
        int businessClassFrequentFlyers = int.Parse(businessClassInfo[1]);
        int businessClassMealPurchase = int.Parse(businessClassInfo[2]);
        decimal businessClassIncome = (businessClassFrequentFlyers * 1050M) +
            (businessClassPassengers - businessClassFrequentFlyers) * 3500M +
            (businessClassMealPurchase * (0.005M * 3500M));
        decimal businessClassMaxIncome = 28 * 3500 * 1.005M;

        string economyClassInput = Console.ReadLine();
        string[] economyClassInfo = economyClassInput.Split(' ');
        int economyClassPassengers = int.Parse(economyClassInfo[0]);
        int economyClassFrequentFlyers = int.Parse(economyClassInfo[1]);
        int economyClassMealPurchase = int.Parse(economyClassInfo[2]);
        decimal economyClassIncome = (economyClassFrequentFlyers * 300M) +
        (economyClassPassengers - economyClassFrequentFlyers) * 1000M +
          (economyClassMealPurchase * (0.005M * 1000M));
        decimal economyClassMaxIncome = 50 * 1000 * 1.005M;


        int allIncome = (int)(economyClassIncome + firstClassIncome + businessClassIncome);
        int allMaxIncome = (int)(firstClassMaxIncome + businessClassMaxIncome + economyClassMaxIncome);
        int difference = (int)(allMaxIncome - allIncome);

        Console.WriteLine(allIncome);
        Console.WriteLine(difference);
    }
}
