using System;
class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int thousands = (n / 1000) % 10;
        int hundreds = (n / 100) % 10;
        int units = (n / 10) % 10;
        int digits = n % 10;
        int nSum = thousands + hundreds + units + digits;
        bool isFound = false;
        for (int a = 1; a <= 5; a++)
        {
            for (int b = 1; b <= 5; b++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    for (int d = 1; d <= 5; d++)
                    {
                        for (int e = 1; e <= 5; e++)
                        {
                            for (int f = 1; f <= 5; f++)
                            {
                                if(a*b*c*d*e*f==nSum)
                                {
                                    isFound = true;

                                    if (a == 1 )
                                    {
                                        Console.Write(".----|");    
                                    }
                                    else if (a == 2)
                                    {
                                        Console.Write("..---|");
                                    }
                                    else  if (a == 3)
                                    {
                                        Console.Write("...--|");
                                    }
                                    else if (a == 4)
                                    {
                                        Console.Write("....-|");
                                    }
                                    else if (a == 5)
                                    {
                                        Console.Write(".....|");
                                    }

                                
                                    if (b == 1)
                                    {
                                        Console.Write(".----|");
                                    }
                                    else if (b == 2)
                                    {
                                        Console.Write("..---|");
                                    }
                                    else if (b == 3)
                                    {
                                        Console.Write("...--|");
                                    }
                                    else if (b == 4)
                                    {
                                        Console.Write("....-|");
                                    }
                                    else if (b == 5)
                                    {
                                        Console.Write(".....|");
                                    }
                                 

                                    if (c == 1)
                                    {
                                        Console.Write(".----|");
                                    }
                                    else if (c == 2)
                                    {
                                        Console.Write("..---|");
                                    }
                                    else if (c == 3)
                                    {
                                        Console.Write("...--|");
                                    }
                                    else if (c == 4)
                                    {
                                        Console.Write("....-|");
                                    }
                                    else if (c == 5)
                                    {
                                        Console.Write(".....|");
                                    }

                                    if (d == 1)
                                    {
                                        Console.Write(".----|");
                                    }
                                    else if (d == 2)
                                    {
                                        Console.Write("..---|");
                                    }
                                    else if (d == 3)
                                    {
                                        Console.Write("...--|");
                                    }
                                    else if (d == 4)
                                    {
                                        Console.Write("....-|");
                                    }
                                    else if (d == 5)
                                    {
                                        Console.Write(".....|");
                                    }

                                    if (e == 1)
                                    {
                                        Console.Write(".----|");
                                    }
                                    else if (e == 2)
                                    {
                                        Console.Write("..---|");
                                    }
                                    else if (e == 3)
                                    {
                                        Console.Write("...--|");
                                    }
                                    else if (e == 4)
                                    {
                                        Console.Write("....-|");
                                    }
                                    else if (e == 5)
                                    {
                                        Console.Write(".....|");
                                    }

                                    if (f == 1)
                                    {
                                        Console.Write(".----|");
                                    }
                                    else if (f == 2)
                                    {
                                        Console.Write("..---|");
                                    }
                                    else if (f == 3)
                                    {
                                        Console.Write("...--|");
                                    }
                                    else if (f == 4)
                                    {
                                        Console.Write("....-|");
                                    }
                                    else if (f == 5)
                                    {
                                        Console.Write(".....|");
                                    }
                                    Console.WriteLine();                    
                                }
                            }
                        }
                    }
                }
            }
        }
        if(!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
