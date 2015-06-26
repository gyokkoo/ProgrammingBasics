using System;
/*
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement. 
 */
class PrintaDeck
{
    static void Main()
    {
        Console.Title = "Problem 4.	Print a Deck of 52 Cards";
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int card = 2; card <=14; card++)
        {
            for (int symbol = 1; symbol <= 4; symbol++) 
            {
                switch (card)
                {
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                    default:
                    case 2: Console.Write("{0}", card); break;
                }
                switch(symbol)
                {
                    case 1: Console.Write("♣ "); break;
                    case 2: Console.Write("♦ "); break;
                    case 3: Console.Write("♥ "); break;
                    case 4: Console.Write("♠ "); break;
                }
            }
            Console.WriteLine();
        }
    }
}