using System;
using System.Collections.Generic;
class BitsAtCrossroads
{
    static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        int[,] board = new int[boardSize, boardSize];
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                board[row, col] = 0;
            }
        }
        int crossroadsCounter = 0;
        string input = "";
        int inputCounter = 0;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            string[] coordinates = input.Split();
            int lineNumber = int.Parse(coordinates[0]);
            int bitPosition = (boardSize - 1 - int.Parse(coordinates[1]));
            int sum = 0;
            int diff = 0;
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (row == lineNumber && col == bitPosition)
                    {
                        board[row, col] = 1; //(2,2)
                        sum = row + col;
                        diff = row - col;
                    }
                }
            }

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (row + col == sum)
                    {
                        if (board[row, col] == 1)
                        {
                            crossroadsCounter++;
                        }
                        board[row, col] = 1;
                    }
                    if (row - col == diff)
                    {
                        if (board[row, col] == 1)
                        {
                            crossroadsCounter++;
                        }
                        board[row, col] = 1;
                    }
                }
            }
            inputCounter++;
        }

        string result = "";
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                result += (board[row, col] + "");
            }
            long finalResult = Convert.ToInt64(result, 2);
            Console.WriteLine(finalResult);
            result = "";
        }
        Console.WriteLine(crossroadsCounter - inputCounter);
    }
}
