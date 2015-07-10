using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string('*', n + 2));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2), new string('-', n));
        }

        int outDots = n / 2 - 1;
        int inDots = n - 2;
        int inAsteriks = 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outDots), new string('*', inAsteriks), new string('-', inDots));
            outDots--;
            inDots -= 2;
            inAsteriks += 2;
        }
        outDots = 1;
        inDots = 3;
        inAsteriks = n - 2;
        for (int i = 0; i < n / 2; i++)
        {

            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outDots), new string('*', inAsteriks), new string('-', inDots));
            outDots++;
            inDots += 2;
            inAsteriks -= 2;
        }
    }
}