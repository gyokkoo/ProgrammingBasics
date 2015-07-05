using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
The letters should be listed in alphabetical order. Use the input and output format from the examples below. 
Examples:
Input	        Output
b b a a b   	a -> 2
                b -> 3
 */
class CountOfLetters
{
    static void Main() //решението не е мое
    {
        Console.Title = "Problem 11.	Count of Letters";
        Console.WriteLine("Enter a text with letters, separated by space.");
        string text = Console.ReadLine().ToLower();

        // this dictionary will hold the pairs: letter (key) -> count (value)
        Dictionary<char, int> dict = new Dictionary<char, int>();

        // if we come across a letter in the text - we add the letter and is count to the dictionary
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                if (!dict.ContainsKey(text[i])) // if the letter is not already added
                {
                    dict.Add(text[i], text.Count(x => x == text[i]));
                }
            }
        }

        // we want the dictionary letter-keys sorted lexicographically
        var list = dict.Keys.ToList();
        list.Sort();

        // printing
        foreach (var key in list)
        {
            Console.WriteLine("{0} -> {1}",
                key, dict[key]);
        }
    }
}