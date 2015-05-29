using System;
/*
 Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values
 by using some programming logic. Print the variable values before and after the exchange. 
 */
class ExchangeVariableValues
{
    static void Main()
    {   //first solution
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\na={0}\nb={1}", a, b);
        int oldA = a; //using temporary variable for exchanging the variables
        a = b;
        b = oldA;
        Console.WriteLine("After:\na={0}\nb={1}", a, b);

        //second solution
        a = 5;
        b = 10;
        Console.WriteLine("Before:\na={0}\nb={1}", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After:\na={0}\nb={1}", a, b);
    }
}
