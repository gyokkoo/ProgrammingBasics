using System;
using System.Linq;
using System.Text.RegularExpressions;
/*
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com 
 */
class ExtractURLfromText
{
    static void Main()
    {
        Console.Title = "Problem 15.	Extract URLs from Text";
        Console.WriteLine("Enter text.");
        string input = Console.ReadLine();
        string[] wordArray = input.Split(' ').ToArray();
        Console.WriteLine("The links in the text are:");
        foreach (string word in wordArray)
        {
            if(isUrl(word))
            {
                Console.WriteLine(word);
            }
        }
        Console.WriteLine();
    }
    static bool isUrl(string url)
    {
        string pattern = @"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*";
        Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return reg.IsMatch(url);
    }
}
