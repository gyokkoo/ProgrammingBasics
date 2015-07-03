using System;
class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int inAsteriks = n - 2;
        int outDots = 1;

        Console.WriteLine("{0}", new string('*', n));
        if (n != 3)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', outDots), new string('*', inAsteriks));
                inAsteriks -= 2;
                outDots += 1;
            }
        }
        Console.WriteLine("{0}*{0}", new string('.', n / 2));
        if (n != 3)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {
                outDots -= 1;
                inAsteriks += 2;
                Console.WriteLine("{0}{1}{0}", new string('.', outDots), new string('*', inAsteriks));
            }
        }
        Console.WriteLine("{0}", new string('*', n));
    }
}