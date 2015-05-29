using System;
/*
 Create a program that assigns null values to an integer and to a double variable. 
 Try to print these variables at the console. Try to add some number or the null literal to these variables
 and print the result. 
 */
class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? variableInt = null;
        double? variableDouble = null;
        Console.WriteLine(variableInt);
        Console.WriteLine(variableDouble);
        variableInt = variableInt + 15;
        variableDouble = variableDouble + 10;
        Console.WriteLine(variableInt);
        Console.WriteLine(variableDouble);
    }
}
