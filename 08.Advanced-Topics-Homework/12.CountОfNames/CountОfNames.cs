using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. Examples:
Input	Output
Peter Steve Nakov Steve Alex Nakov	    Alex -> 1
                                        Nakov -> 2
                                        Peter -> 1
                                        Steve -> 2

 */
class CountОfNames
{
    static void Main()
    {
        Console.Title = "Problem 12.	Count of Names";
        Console.WriteLine("Enter list of names:");
        List<string> names = Console.ReadLine().Split(' ').ToList();

        // this dictionary will hold the pairs: name (key) -> count (value)
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // if we come across a name in the list - we add the name and is count to the dictionary
        for (int i = 0; i < names.Count; i++)
        {
            if (!dict.ContainsKey(names[i])) // if the name is not already added
            {
                dict.Add(names[i], names.Count(x => x == names[i]));
            }
        }

        // we want the dictionary name-keys sorted lexicographically
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