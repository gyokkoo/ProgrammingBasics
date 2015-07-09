using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n)); //top
        int outDots = n - 2;
        int inDots = n + 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            outDots -= 2;
            inDots += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));

        outDots = n - 4;
        inDots = 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', outDots), new string('.', inDots), new string('.', n));
            outDots -= 2;
            inDots += 2;
        }

        outDots = n - 1;
        inDots = n;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            outDots--;
            inDots += 2;
        }

        Console.WriteLine(new string('*', 3 * n)); //bottom
    }
}

