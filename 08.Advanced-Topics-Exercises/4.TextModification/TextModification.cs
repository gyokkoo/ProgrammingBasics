using System;
/*
You are given a string. Go through all letters and if the letter's ASCII code divides by 3 without remainder, 
raise the letter to upper case.
Input	
you though this deer was real…nope, just chuck testa.	
Output
yOU thOUgh thIs deeR was ReaL...nOpe, jUst ChUCk testa.
 */
class TextModification
{
    static void Main()
    {
        Console.Title = "Problem 4.	Text Modification";
        Console.WriteLine("Enter string.");
        Console.Write("Input = ");
        string input = Console.ReadLine();
        string output = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] % 3 == 0)
            {
                output += char.ToUpper(input[i]);
            }
            else
            {
                 output += input[i];
            }
        }
        Console.WriteLine("Output = {0}", output);
    }
}