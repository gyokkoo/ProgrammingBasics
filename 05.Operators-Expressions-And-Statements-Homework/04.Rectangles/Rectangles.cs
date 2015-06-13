using System;
/*
 Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
width	height	perimeter	area
3	    4	    14	        12
2.5  	3	    11	        7.5
5	    5	    20	        25
 
 */
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter the width and height of rectangle to see its perimeter and area");
        Console.Write("widht=");
        double widthRectangle = double.Parse(Console.ReadLine());
        Console.Write("height=");
        double heightRectangle = double.Parse(Console.ReadLine());
        double perimeter = (widthRectangle + heightRectangle) * 2;
        double area = widthRectangle * heightRectangle;
        Console.WriteLine("The perimeter of rectangle is {0}", perimeter);
        Console.WriteLine("The prea of rectangle is {0}", area);
    }
}
