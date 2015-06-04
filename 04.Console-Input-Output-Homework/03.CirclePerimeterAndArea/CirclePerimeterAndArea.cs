using System;
/*
 Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 
  2 digits after the decimal point. Examples: 
 r	 | perimeter	| area
 2	 | 12.57	    | 12.57
 3.5 | 21.99	    | 38.48

 */
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of a circle");
        Console.Write("r=");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * radius * Math.PI; //Math.PI constans is 3.14159265358979
        double area = radius * radius * Math.PI;
        Console.WriteLine("perimeter={0:F2}", perimeter); //F2 format the {0} with 2 digits after the decimal point.
        Console.WriteLine("area={0:F2}", area);
    }
}