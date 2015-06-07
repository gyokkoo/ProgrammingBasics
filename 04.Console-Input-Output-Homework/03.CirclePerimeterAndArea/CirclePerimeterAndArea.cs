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
        Console.WriteLine("Enter radius of a circle");
        Console.Write("r=");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine("The circle's perimeter is {0:F2}", perimeter);
        Console.WriteLine("The circle's area is {0:F2}", area);
    }
}