using System;
/*
 Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
 int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 Choose a large enough type for each number to ensure it will fit in it. 
 Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.
 */
class DeclareVariables
{
    static void Main()
    {
        //52130, -115, 4825932, 97, -10000;
        //declaring variables:
        ushort firstVariable = 52130; // ushort (0 to 65,535)
        sbyte secondVariable = -115; // sbyte (-128 to 127)
        int thirdVariable = 4825932; // int (-2,147,483,648 to 2,147,483,647)
        byte fourthVariable = 97; // byte (0 to 255)
        short fifthVariable = -10000; // short (-32,768 to 32,767)
        //normal output:
        Console.WriteLine("The first number is " + firstVariable);
        Console.WriteLine("The second number is " + secondVariable);
        Console.WriteLine("The third number is " + thirdVariable);
        Console.WriteLine("The fourth number is " + fourthVariable);
        Console.WriteLine("The fifth number is " + fifthVariable);   
        //output using placeholder and \n for new line:
        //Console.WriteLine("The first number is {0}\nThe second number is {1}\nThe third number is {2}\nThe fourth number is {3}\nThe fifth number is {4}", firstVariable, secondVariable, thirdVariable, fourthVariable, fifthVariable);
    }
}

