using System;

public class GameOfLife
{
    public static void Main()
    {
        int[] board = new int[10];
        int[] boardCopy = new int[10];

        int countOfLiveCells = int.Parse(Console.ReadLine());

        for (int i = 0; i < countOfLiveCells; i++)
        {
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            board[row] |= 1 << column;
            boardCopy[row] |= 1 << column;
        }

        for (int row = 0; row < boardCopy.Length; row++)
        {
            for (int col = 0; col < boardCopy.Length; col++)
            {
                int currentBitValue = (boardCopy[row] >> col) & 1;

                int startRow = Math.Max(0, row - 1);
                int endRow = Math.Min(boardCopy.Length - 1, row + 1);
                int startCol = Math.Max(0, col - 1);
                int endCol = Math.Min(boardCopy.Length - 1, col + 1);

                int countOfLiveNeighbours = 0;

                for (int i = startRow; i <= endRow; i++)
                {
                    for (int j = startCol; j <= endCol; j++)
                    {
                        if (i == row && j == col)
                        {
                            continue;
                        }

                        if (((boardCopy[i] >> j) & 1) == 1)
                        {
                            countOfLiveNeighbours++;
                        }
                    }
                }

                if (currentBitValue == 1)
                {
                    if (countOfLiveNeighbours < 2 || 3 < countOfLiveNeighbours)
                    {
                        board[row] &= ~(1 << col);
                    }
                }
                else
                {
                    if (countOfLiveNeighbours == 3)
                    {
                        board[row] |= 1 << col;
                    }
                }
            }
        }

        foreach (var row in board)
        {
            Console.WriteLine(Convert.ToString(row, 2).PadLeft(10, '0'));
        }
    }
}