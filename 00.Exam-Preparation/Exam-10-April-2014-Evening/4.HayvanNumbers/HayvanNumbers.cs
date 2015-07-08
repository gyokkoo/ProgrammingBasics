using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int abc;
        int def;
        int ghi;
        bool hayvanNumber = true;
        for (int a = 5; a <= 9; a++)
        {
            for (int b = 5; b <= 9; b++)
            {
                for (int c = 5; c <= 9; c++)
                {
                    abc = a * 100 + b * 10 + c;
                    for (int d = 5; d <= 9; d++)
                    {
                        for (int e = 5; e <= 9; e++)
                        {
                            for (int f = 5; f <= 9; f++)
                            {
                                def = d * 100 + e * 10 + f;
                                for (int g = 5; g <= 9; g++)
                                {
                                    for (int h = 5; h <= 9; h++)
                                    {
                                        for (int i = 5; i <= 9; i++)
                                        {
                                            ghi = g * 100 + h * 10 + i;
                                            if ((sum == a + b + c + d + e + f + g + h + i) && (diff == ghi - def) && (diff == def - abc) && (abc <= def) && (def <= ghi))
                                            {
                                                Console.WriteLine(abc * 1000000 + def * 1000 + ghi);
                                                hayvanNumber = false;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (hayvanNumber)
        {
            Console.WriteLine("No");
        }
    }
}