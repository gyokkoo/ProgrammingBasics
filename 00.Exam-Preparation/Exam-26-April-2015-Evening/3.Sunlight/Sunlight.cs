using System;
class Sunlight
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int width = 3 * size;
        Console.WriteLine("{0}*{0}", new string('.', width / 2)); //top
        int outerDots = 1;
        int innerDots = width / 2 - 2;
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots++;
            innerDots--;
        }
        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        }
        Console.WriteLine("{0}", new string('*', width));
        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        }
        for (int i = 0; i < size - 1; i++)
        {
            outerDots--;
            innerDots++;
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
        }
        Console.WriteLine("{0}*{0}", new string('.', width / 2)); //last
    }
}