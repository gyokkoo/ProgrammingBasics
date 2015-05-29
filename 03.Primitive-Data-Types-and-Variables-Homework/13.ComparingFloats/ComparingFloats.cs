using System;
/*
 Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
 Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of
 the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each 
 other than a fixed constant eps.
 */
class ComparingFloats
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (firstNum > secondNum)
        {
            if (firstNum - secondNum < eps)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }

        }
        else if (secondNum > firstNum)
        {
            if (secondNum - firstNum < eps)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
