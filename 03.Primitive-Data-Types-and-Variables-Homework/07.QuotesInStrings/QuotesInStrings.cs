using System;
/*
Declare two string variables and assign them with following value:
[ The "use" of quotations causes difficulties. ]
Do the above in two different ways: with and without using quoted strings. 
Print the variables to ensure that their value was correctly defined.
 */
class QuotesInStrings
{
    static void Main()
    {
        string firstQuotedString = @"The ""use"" of quotations causes difficulties."; // @ prefix ignore the used escaping sequences: @"<value>"
        string secondQuotedString = "The \"use\" of quotations causes difficulties."; // 
        Console.WriteLine(firstQuotedString);
        Console.WriteLine(secondQuotedString);
    }
}
