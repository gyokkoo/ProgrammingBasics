using System;
using System.Collections.Generic;
class ArrayMatcher
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split('\\');
        string firstInput = "";
        string secondInput = "";
        string command = "";
        for (int i = 0; i < 3; i++)
        {
            firstInput = inputArray[0];
            secondInput = inputArray[1];
            command = inputArray[2];
        }

        char[] firstArray = firstInput.ToCharArray();
        char[] secondArray = secondInput.ToCharArray();
        List<char> newList = new List<char>();
        int k = 0;
        if (command == "join")
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        newList.Add(firstArray[i]);
                    }
                }
            }
        }
        else if (command == "right exclude")
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                newList.Add(firstArray[i]);
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        newList.Remove(firstArray[i]);
                    }
                }
            }
        }
        else if (command == "left exclude")
        {
            for (int j = 0; j < secondInput.Length; j++)
            {
                newList.Add(secondInput[j]);
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (secondArray[j] == firstArray[i])
                    {
                        newList.Remove(secondArray[j]);
                    }
                }
            }
        }
        newList.Sort();
        foreach (char element in newList)
        {
            Console.Write(element);
        }
        Console.WriteLine();
    }
}