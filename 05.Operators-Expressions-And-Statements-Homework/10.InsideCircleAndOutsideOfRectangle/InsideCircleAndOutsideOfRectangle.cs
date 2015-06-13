using System;
/*
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2). 
Examples:
x	y	inside K & outside of R	 
1	2	yes	
2.5	2	no	
0	1	no	
2.5	1	no	
2	0	no	
4	0	no	
2.5	1.5	no	
2	1.5	yes	
1	2.5	yes	
-100	-100	no	
 
 */
class InsideCircleAndOutsideOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates X and Y of a point to see if it is inside a circle & outside of rectangle");
        Console.Write("X=");
        double coordinateX = double.Parse(Console.ReadLine());
        Console.Write("Y=");
        double coordinateY = double.Parse(Console.ReadLine());
        bool insideCircle = false;
        bool outsideOfRectangle = true;
        if (((coordinateX - 1) * (coordinateX - 1) + (coordinateY - 1) * (coordinateY - 1)) <= (1.5 * 1.5))
        {
            insideCircle = true; 
        }
        if ((coordinateY >= -1 && coordinateY <= 1) && (coordinateX >= -1 && coordinateX <= 5))
        {
            outsideOfRectangle = false;
        }
        Console.WriteLine(insideCircle && outsideOfRectangle == true ? "yes" : "no");
    }
}