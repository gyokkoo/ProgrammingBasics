using System;

class Gambling
{
    static void Main()
    {
        double cashC = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] cards = input.Split(' ');
        double houseHandStrength = 0;
        for (int i = 0; i < cards.Length; i++)
        {
            houseHandStrength += cardStrenght(cards[i]);
        }

        double allCards = 0;
        double winingCards = 0;
        for (int a = 2; a <= 14; a++)
        {
            for (int b = 2; b <= 14; b++)
            {
                for (int c = 2; c <= 14; c++)
                {
                    for (int d = 2; d <= 14; d++)
                    {
                        allCards++;
                        if (a + b + c + d > houseHandStrength) 
                        {
                            winingCards++;
                        }
                    }
                }
            }
        }
        double probability = winingCards / allCards;
        double expectedWinnings = 2 * cashC * probability;
        if(probability<0.50)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:F2}", expectedWinnings);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:F2}", expectedWinnings);
        }
    }
    static int cardStrenght (string card)
    {
        int cardPower = 0;
        switch(card)
        {
            case "2": cardPower = 2; break;
            case "3": cardPower = 3; break;
            case "4": cardPower = 4; break;
            case "5": cardPower = 5; break;
            case "6": cardPower = 6; break;
            case "7": cardPower = 7; break;
            case "8": cardPower = 8; break;
            case "9": cardPower = 9; break;
            case "10": cardPower = 10; break;
            case "J": cardPower = 11; break;
            case "Q": cardPower = 12; break;
            case "K": cardPower = 13; break;
            case "A": cardPower = 14; break;
        }
        return cardPower;
    }
}