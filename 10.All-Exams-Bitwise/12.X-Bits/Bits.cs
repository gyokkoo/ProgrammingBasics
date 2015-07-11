using System;

class Bits
{
    static void Main()
    {
        int[] board = new int[8];
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = int.Parse(Console.ReadLine());
        }

        int[,] n = new int[8, 8];
        for (int row = 0; row < 8; row++)
        {
            string number = Convert.ToString(board[row], 2).PadLeft(8, '0');
            char[] numCh = number.ToCharArray();
            for (int col = 0; col < 8; col++)
            {
                n[row, col] = (numCh[col] - 48);
                Console.Write(n[row, col] + " ");
            }
            Console.WriteLine();
        }
        int xBitCounter = 0;
        for (int r = 1; r < 7; r++)
        {
            for (int c = 1; c < 7; c++)
            {
                if (n[r, c] == n[r - 1, c - 1] && n[r - 1, c + 1] == n[r, c] && n[r + 1, c - 1] == n[r, c] && n[r + 1, c + 1] == n[r, c] && n[r, c] == 1)
                {
                    if (n[r + 1, c] == n[r - 1, c] && n[r, c - 1] == n[r, c + 1] && n[r + 1, c] == n[r, c - 1] && n[r + 1, c] == 0)
                        xBitCounter++;
                }
            }
        }
        Console.WriteLine(xBitCounter);
    }
}