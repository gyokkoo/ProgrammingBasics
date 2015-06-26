using System;
/*
Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
on a single line, separated by a space. Examples:
n	output
3	1 2 3
5	1 2 3 4 5
 */
class NumbersFromOneToN
{
    static void Main()
    {
        Console.Title = "Problem 1.	Numbers from 1 to N";
        Console.WriteLine("Enter positive integer n.");
        Console.Write("n = ");
        string line = Console.ReadLine();
        try
        {
            uint integerN = uint.Parse(line);
            for (int i = 1; i <= integerN; i++)
            {
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
