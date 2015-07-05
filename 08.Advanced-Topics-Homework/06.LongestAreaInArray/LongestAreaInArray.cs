using System;
/*
Write a program to find the longest area of equal elements in array of strings. 
You first should read an integer n and n strings (each at a separate line), then find and print the longest 
sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, 
print the leftmost of them.
 */
class LongestAreaInArray
{
    static void Main()
    {
        Console.Title = "Problem 6.	Longest Area in Array";
        Console.WriteLine("Enter integer n and n string, each at separated line");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        string[] stringArray = new string[n];
        string lastString = "";
        string longestSequenceString = "";
        string firstString = "";
        int longestSequence = 1;
        int currentSequence = 0;
        for (int i = 0; i < n; i++)
        {
            firstString = stringArray[0];
            stringArray[i] = Console.ReadLine();
            if(lastString == stringArray[i])
            {
                currentSequence++;
                if(currentSequence> longestSequence)
                {
                    longestSequence = currentSequence;
                    longestSequenceString = stringArray[i];
                }
            }
            else
            {
                currentSequence = 1;
            }
            lastString = stringArray[i];
        }
        Console.WriteLine(longestSequence);
        if (longestSequence == 1)
        {
            Console.WriteLine(firstString);
        }
        else
        {
            for (int i = 1; i <= longestSequence; i++)
            {
                Console.WriteLine(longestSequenceString);
            }
        }
    }
}
