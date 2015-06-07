using System;
/*
 Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. Examples:
numbers	    sum		numbers	        sum		numbers	            sum
1 2 3 4 5	15		10 10 10 10 10	50		1.5 3.14 8.2 -1 0	11.84
 */
class SumOfFiveNums
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers, in a single line, separated by a space, to see their sum");
        string[] nums = new string[5];
        double sum = 0;
        nums = Console.ReadLine().Split();
        for (int i = 0; i < nums.Length; i++)
        {
            sum += Convert.ToDouble(nums[i]);
        }
        Console.WriteLine("The sum of the numbers is {0}", sum);
    }
}