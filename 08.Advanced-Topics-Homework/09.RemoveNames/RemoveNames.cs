using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
The input and output lists are given as words, separated by a space, each list at a separate line.  
 */
class RemoveNames
{
    static void Main()
    {
        Console.Title = "Problem 9.	Remove Names";
        Console.WriteLine("Enter two lists of names separated by a space, each list in a separate line.");
        Console.Write("Enter first names -> ");
        List<string> firstNames = Console.ReadLine().Split(' ').ToList();
        Console.Write("Enter second names -> ");
        List<string> secondNames = Console.ReadLine().Split(' ').ToList();

        for (int i = 0; i < secondNames.Count; i++)
        {
            if(firstNames.Contains(secondNames[i]))
            {
                firstNames.RemoveAll(item => item == secondNames[i]);
            }
        }
        Console.WriteLine();
        Console.Write("The first list without names in the second list ->");
        Console.WriteLine(string.Join(" ", firstNames));
        Console.WriteLine();
    }
}