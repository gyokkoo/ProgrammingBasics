using System;
/*
Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
n	Catalan(n)
0	1
5	42
10	16796
15	9694845

 */
class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "Problem 8.	Catalan Numbers";
        Console.WriteLine("Enter integer n (1<n<100).");
        Console.Write("n = ");
        double factorialN = 1;
        double factorial2N = 1;
        double factorialNplus1 = 1;
        double n = double.Parse(Console.ReadLine());
        for (int i = 1; i <= 2*n; i++)
        {
            factorial2N *= i;
            if (i <= n + 1)
            {
                factorialNplus1 *= i;  
            }
            if (i <= n) 
            {
                factorialN *= i;
            }
        }
        double catalanN = factorial2N / (factorialNplus1 * factorialN);
        Console.WriteLine("Catalan(n) = {0} ", catalanN);
}
}
