using System;
using System.Globalization;
using System.Threading;
/*
A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or 
“non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
Note that you may need to learn how to parse dates and times. Examples:
time	    result
1:00 PM  	beer time
4:30 PM	    beer time
10:57 PM	beer time
8:30 AM	    non-beer time
 
 */
class BeerTime
{
    static void Main() // решението не е мое!
    {
        Console.Title = "Problem 10.	* Beer Time";
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        Console.WriteLine("Enter a time in format \"hh:mm tt\" (for example 10:30 AM)");
        Console.Write("time = ");
        string dateString = Console.ReadLine();
        if (DateTime.TryParseExact(dateString, "h:mm tt", enUS, DateTimeStyles.None, out time))
        {
            if (time>= startTime || time < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else 
        {
            Console.WriteLine("invalid time");
        } 
    }
}