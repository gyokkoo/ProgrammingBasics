using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
Input	Output
3 6 	aaa aba aca	ada aea afa
        bbb bcb bdb	beb bfb bgb
        ccc cec cdc	cfc cgc chc
 */
class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Title = "Problem 7.	Matrix of Palindromes";
        Console.WriteLine("Enter the rows and columns for the Matrix.");
        Console.Write("rows = ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("columns = ");
        int c = int.Parse(Console.ReadLine());

        List<string> palindromes = MakePalindromes();

        string[,] matrix = new string[r, c];
        int index = 0;
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = palindromes[index];
                index++;
            }
            index += 27 - c; // make sure each row starts with a next letter
        }

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    private static List<string> MakePalindromes()
    {
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<string> palindromes = new List<string>();

        for (int c1 = 0; c1 < letters.Length; c1++)
        {
            for (int c2 = 0; c2 < letters.Length; c2++)
            {
                for (int c3 = 0; c3 < letters.Length; c3++)
                {
                    string temp = "" + letters[c1] + letters[c2] + letters[c3];
                    if (PalindromeCheck(temp))
                    {
                        palindromes.Add(temp);
                    }
                }
            }
        }
        return palindromes;
    }
    private static bool PalindromeCheck(string s)
    {
        bool isPalindrome = false;
        if (s == String.Join("", s.Reverse()))
        {
            isPalindrome = true;
        }
        return isPalindrome;
    }
}