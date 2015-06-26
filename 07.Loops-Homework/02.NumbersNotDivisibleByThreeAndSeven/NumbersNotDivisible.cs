using System;
/*
Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. Examples:
n	output
3	1 2
10	1 2 4 5 8 10 
 */
class NumbersNotDivisible
{
    static void Main()
    {
        Console.Title = "Problem 2.	Numbers Not Divisible by 3 and 7";
        Console.WriteLine("Enter positive integer n.");
        Console.Write("n = ");
        string line = Console.ReadLine();
        try
        {
            uint integerN = uint.Parse(line);
            for (int i = 1; i <= integerN; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("{0} is not an positive integer!", line);
        }     
        catch (SystemException)
        {
            Console.WriteLine("{0} is not an positive integer or is too long!", line);
        }
    }
}
