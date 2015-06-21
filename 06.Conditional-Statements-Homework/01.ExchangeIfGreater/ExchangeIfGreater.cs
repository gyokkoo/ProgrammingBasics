using System;
/*
Write an if-statement that takes two integer variables a and b and 
exchanges their values if the first one is greater than the second one. 
As a result print the values a and b, separated by a space. 
a	b	result
5	2	2 5
3	4	3 4
*/
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Title = "Problem 1.	Exchange If Greater";
        Console.Write("a = ");
        double variableA = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double variableB = double.Parse(Console.ReadLine());
        if (variableA > variableB)
        {
            variableA += variableB;
            variableB = variableA - variableB;
            variableA = variableA - variableB;
        }
        Console.WriteLine(variableA + " " + variableB);
    }
}