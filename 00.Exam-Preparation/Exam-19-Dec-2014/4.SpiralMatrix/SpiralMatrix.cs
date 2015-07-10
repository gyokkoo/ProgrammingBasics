using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine().ToUpper();
        char[] ch = word.ToCharArray();
        char[,] matrix = new char[n, n];

        int x = 0, y = 0, size = n, currentChar = 0;
        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                matrix[x, i] = word[currentChar % word.Length];
                currentChar++;
            }
            for (int j = x + 1; j <= x + size - 1; j++)
            {
                matrix[j, y + size - 1] = word[currentChar % word.Length];
                currentChar++;
            }
            for (int i = y + size - 2; i >= y; i--)
            {
                matrix[x + size - 1, i] = word[currentChar % word.Length];
                currentChar++;
            }
            for (int i = x + size - 2; i >= x + 1; i--)
            {
                matrix[i, y] = word[currentChar % word.Length];
                currentChar++;
            }

            x = x + 1;
            y = y + 1;
            size = size - 2;
        }

        int maxWeight = 0;
        int rowNumber = 0;
        for (int row = 0; row < n; row++)
        {
            int currentWeight = 0;
            for (int col = 0; col < n; col++)
            {
                currentWeight += (matrix[row, col] - 64);
            }
            if (currentWeight > maxWeight)
            {
                maxWeight = currentWeight;
                rowNumber = row;
            }
        }
        Console.WriteLine(rowNumber + " - " + maxWeight * 10);
    }
}
