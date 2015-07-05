using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first 
list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. 
The input and output lists are given as integers, separated by a space, each list at a separate line. Examples:
Input               	Output
20 40 10 10 30 80
25 20 40 30 10	        10 20 25 30 40 80
 
 */
class JoinLists
{
    static void Main()
    {
        Console.Title = "Problem 10.	Join Lists";
        Console.WriteLine("Enter two lists of integers separated by a space, each list in a separate line.");
        Console.Write("Enter first numbers -> ");
        List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.Write("Enter second numbers -> ");
        List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> result = firstList.Union(secondList).ToList();
        result.Sort();

        Console.WriteLine();
        Console.Write("The result is -> ");
        Console.WriteLine(string.Join(" ", result));
        Console.WriteLine();
    }
}
