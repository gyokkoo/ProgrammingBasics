using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger t1 = long.Parse(Console.ReadLine());
        BigInteger t2 = long.Parse(Console.ReadLine());
        BigInteger t3 = long.Parse(Console.ReadLine());
        BigInteger t4 = 0;
        long n = long.Parse(Console.ReadLine());
        BigInteger result = 0;
        if (n==1)
        {
            Console.WriteLine(t1);
        }
        else if(n==2)
        {
            Console.WriteLine(t2);
        }
        else if(n==3)
        {
            Console.WriteLine(t3);
        }
        else
        {
            for (int i = 1; i <= n - 3; i++)
            {
                t4 = t1 + t2 + t3;
                result = t4;
                t1 = t2;
                t2 = t3;
                t3 = t4;
            }
            Console.WriteLine(result);
        }
    }
}