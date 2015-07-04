using System;
class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (n + 1) / 2), new string('.', n));  //top
        int outDots = n / 2 - 1;
        int inAsteriks = n / 2;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outDots), new string('*', inAsteriks), new string('.', n));
            outDots--;
            inAsteriks++;
        }

        Console.WriteLine("&{0}&{1}&{0}&", new string('*', n - 2), new string('=', n)); //middle

        for (int i = 0; i < n / 2 - 1; i++)
        {

            outDots++;
            inAsteriks--;

            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outDots), new string('*', inAsteriks), new string('.', n));

        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', (n + 1) / 2), new string('.', n)); //end
    }
}
