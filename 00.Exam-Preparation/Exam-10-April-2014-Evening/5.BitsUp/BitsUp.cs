using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] array = new int[8];
        List<int> number = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(input,2));
            for (int j = 7; j >= 0; j--)
            {
                array[7 - j] = (input >> (j)) & 1;
            }
            for (int k = 0; k < 8; k++)
            {
                number.Add(array[k]);
            }
        }
        for (int i = 0; i < number.Count; i++)
        {
            if (step == 1)
            {
                if (i != 0)
                {
                    number[i] = 1;
                }
            }
            else if (i % step == 1)
            {
                number[i] = 1;
            }
        }
        string result = "";
        for (int i = 0; i < number.Count; i++)
        {
            result += (number[i] + "");
            if (i % 8 == 7 && (i != 0))
            {
                Console.WriteLine(Convert.ToInt32(result, 2));
                result = "";
            }
        }
    }
}
