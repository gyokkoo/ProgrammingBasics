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
        Console.Write("Enter a: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Etner b: ");
        double secondNumber = double.Parse(Console.ReadLine());
        //Console.WriteLine("The greater is {0}", Math.Max(firstNumber, secondNumber)); //Using Math.Max Method 
        Console.WriteLine("The greater is: {0}", firstNumber > secondNumber ? firstNumber : secondNumber); //second solution using ?: Operator
        //condition ? first_expression : second_expression;
    }
}