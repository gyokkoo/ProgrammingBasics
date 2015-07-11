using System;
class KnightPath
{
    static void Main()
    {
        int[,] chessBoard = new int[8, 8];
        for (int r = 0; r < 8; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                if (r == 0 && c == 7)
                {
                    chessBoard[r, c] = 1;
                }
                else
                {
                    chessBoard[r, c] = 0;
                }
            }
        }
        string input = "";
        int row = 0;
        int col = 7;
        while (input != "stop")
        {
            input = Console.ReadLine();

            if (input == "down left")
            {
                if (row + 2 <= 7 && col - 1 >= 0)
                {
                    if (chessBoard[row + 2, col - 1] == 1)
                    {
                        chessBoard[row + 2, col - 1] = 0;
                    }
                    else
                    {
                        chessBoard[row + 2, col - 1] = 1;
                    }
                    row = row + 2;
                    col = col - 1;

                }
                continue;
            }
            else if (input == "left down")
            {
                if (row + 1 <= 7 && col - 2 >= 0)
                {
                    if (chessBoard[row + 1, col - 2] == 1)
                    {
                        chessBoard[row + 1, col - 2] = 0;
                    }
                    else
                    {
                        chessBoard[row + 1, col - 2] = 1;
                    }
                    row = row + 1;
                    col = col - 2;
                }
                continue;
            }
            else if (input == "right up")
            {
                if (row - 1 >= 0 && col + 2 <= 7)
                {
                    if (chessBoard[row - 1, col + 2] == 1)
                    {
                        chessBoard[row - 1, col + 2] = 0;
                    }
                    else
                    {
                        chessBoard[row - 1, col + 2] = 1;
                    }
                    row = row - 1;
                    col = col + 2;
                }
                continue;
            }
            else if (input == "right down")
            {
                if (row + 1 <= 7 && col + 2 <= 7)
                {
                    if (chessBoard[row + 1, col + 2] == 1)
                    {
                        chessBoard[row + 1, col + 2] = 0;
                    }
                    else
                    {
                        chessBoard[row + 1, col + 2] = 1;
                    }
                    row = row + 1;
                    col = col + 2;
                }
                continue;
            }
            else if (input == "up left")
            {
                if (row - 2 >= 0 && col - 1 >= 0)
                {
                    if (chessBoard[row - 2, col - 1] == 1)
                    {
                        chessBoard[row - 2, col - 1] = 0;
                    }
                    else
                    {
                        chessBoard[row - 2, col - 1] = 1;
                    }
                    row = row + 1;
                    col = col + 2;
                }
                continue;
            }
            else if (input == "up right")
            {
                if (row - 2 >= 0 && col + 1 <= 7)
                {
                    if (chessBoard[row - 2, col + 1] == 1)
                    {
                        chessBoard[row - 2, col + 1] = 0;
                    }
                    else
                    {
                        chessBoard[row - 2, col + 1] = 1;
                    }
                    row = row - 2;
                    col = col + 1;
                }
                continue;
            }
            else if (input == "left up")
            {
                if (row - 1 >= 0 && col - 2 >= 0)
                {
                    if (chessBoard[row - 1, col - 2] == 1)
                    {
                        chessBoard[row - 1, col - 2] = 0;
                    }
                    else
                    {
                        chessBoard[row - 1, col - 2] = 1;
                    }
                    row = row - 1;
                    col = col - 2;
                }
                continue;
            }
            else if (input == "down right")
            {
                if (row + 2 <= 7 && col + 1 <= 7)
                {
                    if (chessBoard[row + 2, col + 1] == 1)
                    {
                        chessBoard[row + 2, col + 1] = 0;
                    }
                    else
                    {
                        chessBoard[row + 2, col + 1] = 1;
                    }
                    row = row + 2;
                    col = col + 1;
                }
                continue;
            }

        }

        string result = "";
        for (int a = 0; a < 8; a++)
        {
            for (int b = 0; b < 8; b++)
            {
                result += (chessBoard[a, b] + "");
                if (chessBoard[0, 7] == 0)
                {
                    Console.WriteLine("[Board is empty]");
                    break;
                }
            }
            if (chessBoard[0, 7] == 0)
            {
                break;
            }
            int finalResult = Convert.ToInt32(result, 2);
            if (finalResult > 0)
            {
                Console.WriteLine(finalResult);
            }
            result = "";
        }
    }

}