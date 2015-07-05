using System;
/*
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
*/
class DifferenceDates
{
    static void Main()
    {
        Console.Title = "Problem 4.	Difference between Dates";
        Console.WriteLine("Enter two date in format dd.MM.yyyy.");
        Console.Write("First Date = ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Second Date = ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("The difference between {0} and {1} is {2} days", secondDate.ToString("dd.MM.yyyy"), firstDate.ToString("dd.MM.yyyy"), (secondDate - firstDate).Days);
    }
}
