using System;
/*
Write a method Power() that calculates the power of a given number.
•	The method should receive a number and the power as arguments
•	The method should return double as result 
The input should be read from the console.
Input	Output		Input   	Output
3   	9         	7.45
2                       3	     413.493625
Write an overload method with the same name that receives an additional argument - boolean value roundDown. 
If roundDown is true, the result should be rounded down to the nearest integer. Otherwise, return the original result. 
 */
class PowerTask
{
    static void Main()
    {
        Console.Title = "Problem 2.	Power";
        Console.WriteLine("Enter number and power.");
        Console.Write("number = ");
        double number = double.Parse(Console.ReadLine());
        Console.Write("power = ");
        double power = double.Parse(Console.ReadLine());
        double result = Power(number, power);
        bool roundDown = false;
        if(result%1!=0)
        {
            roundDown = true;
        }
        Console.WriteLine(Power(number, power, roundDown));
    }
    static double Power(double number, double power)
    {
        double constNumber = number;
        for (int i = 1; i < power; i++)
        {
            number = constNumber*number;
        }
        return number;
    }
    static double Power(double number, double power, bool roundDown)
    {
        if(roundDown)
        {
            return Math.Round(Power(number,power));
        }
        else 
        {
            return Power(number, power);
        }
    }
}
