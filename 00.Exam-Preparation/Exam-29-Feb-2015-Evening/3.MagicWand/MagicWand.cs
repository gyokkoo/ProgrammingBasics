using System;
class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', (3 * n + 2) / 2)); //top
        int outD = (3 * n + 2) / 2 - 1;
        int inD = 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outD), new string('.', inD));
            outD--;
            inD += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));
        outD = 1;
        inD = 3 * n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outD), new string('.', inD));
            outD++;
            inD -= 2;
        }
        Console.WriteLine("{0}*{1}**{2}**{1}*{0}", new string('.', n / 2 - 1), new string('.', n / 2), new string('.', n));
        int outDots = n / 2 - 2;
        int inDots = 1;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            if (outDots < 0)
            { outDots = 0; }
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', outDots), new string('.', n / 2),
                new string('.', inDots), new string('.', n));
            outDots--;
            inDots++;
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', n / 2 + 1), new string('.', n / 2), new string('.', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', n));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n + 2)); //bottom



    }
}
