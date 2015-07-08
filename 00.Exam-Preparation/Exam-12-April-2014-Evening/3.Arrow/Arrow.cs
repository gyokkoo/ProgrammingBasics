using System;
class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', (n - 1) / 2), new string('#', n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', (n - 1) / 2), new string('.', n - 2));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', (n / 2 + 1)), new string('.', n - 2));
        int outDots = 1;
        int inDots = 2 * n - 5;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', outDots), new string('.', inDots));
            outDots++;
            inDots -= 2;
        }
        Console.WriteLine("{0}#{0}", new string('.', n - 1));
    }
}