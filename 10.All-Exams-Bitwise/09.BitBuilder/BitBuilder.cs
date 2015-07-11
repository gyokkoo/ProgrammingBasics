using System;
class BitBuilder
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        // Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        while (true)
        {
            int p;
            string input = Console.ReadLine();
            {
                if (input == "quit")
                {
                    break;
                }
                else
                {
                    p = int.Parse(input);
                }
            }
            string option = Console.ReadLine();

            if (option == "flip")
            {
                long bitAtPosition = ((number >> p) & 1);
                if (bitAtPosition == 0)
                {
                    number = number | (1 << p);
                }
                else if (bitAtPosition == 1)
                {
                    number = number & ~(1 << p);
                }
                // Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
            else if (option == "remove")
            {
                if (p == 0)
                {
                    number = number >> 1;
                }
                else if (p == 31)
                {
                    number |= ((number >> 31) & 0) << 31;
                }
                else
                {
                    long top = ~((1 << (p + 1)) - 1);
                    long bottom = (1 << p) - 1;
                    //Console.WriteLine(Convert.ToString(top, 2).PadLeft(32, '0'));
                    //Console.WriteLine(Convert.ToString(bottom, 2).PadLeft(32, '0'));
                    number = ((number & top) >> 1) | (number & bottom);
                }
                // Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
            else if (option == "insert")
            {
                if (p == 0)
                {
                    number = (number << 1) & 1;
                }
                else
                {
                    long top = ~((1 << p) - 1);
                    long bottom = (1 << p) - 1;
                    long leftSide = ((number & top) >> (p - 1));
                    long rightSide = (number & bottom);
                    leftSide |= leftSide | 1;
                    number = (leftSide << p) | rightSide;
                }
                //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }

        Console.WriteLine(number);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));


    }
}