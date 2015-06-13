using System;
/*
Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
Examples:
x	y	inside	 
0	1	true	
-2	0	true	
-1	2	false	
1.5	-1	true	
-1.5	-1.5	false	
100	-30	false	
0	0	true	
0.2	-0.8	true	
0.9	-1.93	false	
1	1.655	true	
*/
class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter X and Y coordinates of point to see if that point is in a circle");
        Console.Write("X=");
        double coordinateX = double.Parse(Console.ReadLine());
        Console.Write("Y=");
        double cordinateY = double.Parse(Console.ReadLine());
        double distanteFromTheCenter = Math.Sqrt(coordinateX * coordinateX + cordinateY * cordinateY);
        bool isInACircle = distanteFromTheCenter <= 2 ? true : false;
        Console.WriteLine(isInACircle);
         
    }
}
