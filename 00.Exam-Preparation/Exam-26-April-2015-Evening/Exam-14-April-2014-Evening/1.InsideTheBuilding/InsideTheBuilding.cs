using System;

class InsideTheBuilding
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if ((x >= 0 && x <= 3 * size) && (y >= 0 && y <= size) || 
               ((x>= size && x<= 2*size ) && (y>=size && y<=4*size)))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}