using System;
/*
Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
 by 7 and 5 in the same time. Examples:
n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
 */

class DivideBySevenAndFive
{
    static void Main()
    {
            Console.WriteLine("Please enter integer to see if it can be divided by 7 and 5 in the same time");
            int integerN = int.Parse(Console.ReadLine());
            bool isDivided = (integerN % 7 == 0 && integerN % 5 == 0);
            Console.WriteLine(isDivided);
    }
}
