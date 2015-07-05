using System;
/*
 Write a program to find the longest word in a text. Examples:
Input	                                    Output
Welcome to the Software University.	        University

 */
class LongestWordInText
{
    static void Main()
    {
        Console.Title = "Problem 14.	Longest Word in a Text";
        Console.WriteLine("Enter text.");
        string input = Console.ReadLine();
        string[] word = input.Split(' ', '.', '!', ',', ':', ';');
        string longestWord = "";
        for (int i = 0; i < word.Length; i++)
        {
            if(word[i].Length > longestWord.Length)
            {
                longestWord = word[i];
            }
        }
        Console.WriteLine("The longest word in the text is:");
        Console.WriteLine(longestWord);
    }
}
