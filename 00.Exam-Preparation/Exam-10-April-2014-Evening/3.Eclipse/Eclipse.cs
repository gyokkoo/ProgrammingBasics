using System;
class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(" {0} {1} {0} ", new string('*', (2 * n - 2)), new string(' ', n - 1));
        if (n == 3)
        {
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * n - 2)), new string('-', n - 1));
        }
        else
        {
            for (int i = 1; i < n - 2; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * n - 2)), new string('-', n - 1));
                }
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', (2 * n - 2)), new string(' ', n - 1));
            }
        }
        Console.WriteLine(" {0} {1} {0} ", new string('*', (2 * n - 2)), new string(' ', n - 1));
    }
}