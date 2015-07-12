using System;

class Summertime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outSpaces = n / 2;
        int inSpaces = n - 1;
        Console.WriteLine("{0}{1}{0}", new string(' ', outSpaces), new string('*', n + 1));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', outSpaces), new string(' ', inSpaces));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', outSpaces), new string(' ', inSpaces));
            outSpaces--;
            inSpaces += 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
        }

        Console.WriteLine(new string('*', 2 * n));
    }
}