using System;
/*
 Write a program that gets two numbers from the console and prints the greater of them. 
 Try to implement this without if statements. Examples:
a	  b	   greater
5	  6	   6
10	  5	   10
0	  0	   0
-5	  -2  -2
1.5	  1.6  1.6
 
 */
class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers for compare");
        Console.Write("First nubmer = ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number = ");
        double secondNumber = double.Parse(Console.ReadLine());
        double greater = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is: {0}", greater);
    }
}