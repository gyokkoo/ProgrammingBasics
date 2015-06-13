using System;
/*
 Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
 	Prints on the console the number in reversed order: dcba (in our example 1102).
 	Puts the last digit in the first position: dabc (in our example 1201).
	Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. Examples:
n	  sum of digits	reversed	last digit in front	second and third digits exchanged
2011	4	        1102	    1201	    2101
3333	12       	3333	    3333	    3333
9876	30	        6789	    6987	    9786

 */
class FouDigitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter four-digit number");
        int integerN = int.Parse(Console.ReadLine());
        int thousandths = integerN / 1000;
        int hundreds = (integerN / 100) % 10;
        int tenths = (integerN / 10) % 10;
        int units = integerN % 10;
        Console.WriteLine("Sum of digits are {0}", thousandths + hundreds + tenths + units);
        Console.WriteLine("The number in reserved order is {0}", units * 1000 + tenths * 100 + hundreds * 10 + thousandths * 1);
        Console.WriteLine("The number with last digit in front is {0}", units * 1000 + tenths * 1 + hundreds * 10 + thousandths * 100);
        Console.WriteLine("The number with second and third digits exchanged {0}", units * 1 + tenths * 100 + hundreds * 10 + thousandths * 1000);

 

    }
}

