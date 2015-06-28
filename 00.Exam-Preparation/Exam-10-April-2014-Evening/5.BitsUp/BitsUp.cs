using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int mask = 0;
        int result = 0;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine()); // 01101101 
           // Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
                    
            mask = 1 << 3;
            result = number | mask;
            array [n] = result;
               // Console.WriteLine(Convert.ToString(result, 2).PadLeft(8, '0'));         
        }
     

        //int n = int.Parse(Console.ReadLine());
        //int step = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0'));
        //int mask = 1 >> step;
        //int result = n | mask;
        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(8, '0'));
        //Console.WriteLine(result);
    }
}
