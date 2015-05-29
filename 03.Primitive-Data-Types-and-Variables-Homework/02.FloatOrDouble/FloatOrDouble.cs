using System;
/*
 Which of the following values can be assigned to a variable of type float and which to a variabl of type double:
 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and 
 print them to ensure no precision is lost.  
 */
class FloatOrDouble
{
    static void Main()
    {
        //34.567839023, 12.345, 8923.1234857, 3456.091
        //declarating float and double variables:
        double firstVariable = 34.567839023; //double, precision of 15-16 digits, "d" suffix is not required, because its defaut value is double
        float secondVariable = 12.345f; //flaot, precision of 7 digits, "f" suffix is required
        double thirdVariable = 8923.1234857;
        float fourthVariable = 3456.091f;
        //output 
        Console.WriteLine("The first number is double type: " + firstVariable);
        Console.WriteLine("The second number is float type: " + secondVariable);
        Console.WriteLine("The third number is double type: " + thirdVariable);
        Console.WriteLine("The fourth number is float type: " + fourthVariable);
    }
}

