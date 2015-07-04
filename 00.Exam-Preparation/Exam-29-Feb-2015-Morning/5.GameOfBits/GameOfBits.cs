using System;
class GameOfBits
{
    static void Main()
    {
        long number = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number,2)); 
        string line = "";
        string newNum = "";
        int onesCounter = 0;
        while (true)
        {
            line = Console.ReadLine();
            if (line == "Odd")
            {
                for (int p = 31; p >= 0; p--)
                {
                    if (p % 2 == 0)
                    {
                        long numberRightP = number >> p;
                        newNum += (numberRightP & 1) + ""; // We are collecting 1 and 0 in string
                    }
                }
                number = Convert.ToInt64(newNum, 2); // convert string to decimal
                //Console.WriteLine(number);
                newNum = "";
            }
            else if (line == "Even")
            {
                for (int o = 31; o >= 0; o--)
                {
                    if (o % 2 == 1)
                    {
                        long numberRightO = number >> o;
                        newNum += (numberRightO & 1) + "";
                    }
                }
                number = Convert.ToInt64(newNum, 2); 
                //Console.WriteLine(number);
                newNum = "";
            }
            else if (line == "Game Over!")
            {
                for (int i = 0; i < 32; i++)
                {
                    long isOne = (number >> i) & 1; // returns 1 or 0;
                    if (isOne == 1)
                    {
                        onesCounter++;
                    }
                }
                break;
            }
        }
        Console.WriteLine("{0} -> {1}", number, onesCounter);
    }
}