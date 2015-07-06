using System;
class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        char letter = Convert.ToChar(input);
        int outSymbol = n / 2 - 1;
        int inSymbol = 3;
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), letter);
        for (int i = 0; i < n/2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', outSymbol), new string(letter, inSymbol));
            outSymbol--;
            inSymbol += 2;
        }
        Console.WriteLine(new string(letter, n));
        for (int i = 0; i < n/2 - 1; i++)
        {
            outSymbol++;
            inSymbol -= 2;
            Console.WriteLine("{0}{1}{0}", new string('-', outSymbol), new string(letter, inSymbol));
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), letter);
    }
}