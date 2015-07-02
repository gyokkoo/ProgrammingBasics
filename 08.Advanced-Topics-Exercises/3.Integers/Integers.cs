using System;
/*
Create an array with 10 integers. Fill the array with random integers in the range [0…100]. 
Each subsequent element of the array should add the previous element to its value.
For example, if the randomly generated items are 0 1 2 3 4 5 6 7 8 9, the elements 
in the array should be 0 1 3 6 10 15 21 28 36 45. 
 */
class Integers
{
    static void Main()
    {
        Console.Title = "Problem 3.	Integers";
        int[] arrayN = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < arrayN.Length; i++)
        {
            arrayN[i] = rnd.Next(0, 101);
        }
        Console.WriteLine("Randomly generated numbers in the array:");
        foreach (int number in arrayN)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < arrayN.Length; i++)
        {
            arrayN[i] = arrayN[i] + i;
        }
        Console.WriteLine("The value of the array after adding the previous element to its value:");
        foreach (int number in arrayN)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}