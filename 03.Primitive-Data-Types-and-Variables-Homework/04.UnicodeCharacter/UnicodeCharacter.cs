using System;
/*
 Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
 using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal
 representation of 42.  
 */
class UnicodeCharacter
{
    static void Main()
    {
        //42 in hexadecimal format is 2A
        char hexadecimalVariable = '\u002A'; //'\u00XX' syntax
        Console.WriteLine(hexadecimalVariable);
    }
}
