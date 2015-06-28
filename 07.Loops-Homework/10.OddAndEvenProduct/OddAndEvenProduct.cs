using System;
/*
You are given n integers (given in a single line, separated by a space). 
Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
Elements are counted from 1 to n, so the first element is odd, the second is even, etc. Examples:
numbers	result
2 1 1 6 3	yes
product = 6
 */
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Title = "Problem 10.	Odd and Even Product";
        Console.WriteLine("Enter n integers in a single line, separated by a space.");
        string[] line = Console.ReadLine().Split();
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < line.Length; i++)
        {
            int numbers = int.Parse(line[i]);
            if ((i+1) % 2 == 1)
            {
                oddProduct *= numbers;
            }
            else if ((i+1) % 2 == 0)
            {
                evenProduct *= numbers;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}
