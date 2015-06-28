using System;
/*
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
n	    matrix
2	    1 2
        2 3
 */
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Title = "Problem 9.	Matrix of Numbers";
        Console.WriteLine("Enter a positive integer number n (1<=n<=20)");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write("{0} ", row + col);    
            }
            Console.WriteLine();
        }
    }
}