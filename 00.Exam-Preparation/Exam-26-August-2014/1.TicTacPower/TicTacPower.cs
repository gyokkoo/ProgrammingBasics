using System;

class TicTacPower
{
    static void Main()
    {
        long x = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());
        long number = long.Parse(Console.ReadLine());


        long[,] board = new long[3, 3];
        long i = number;
        long[,] indexes = new long[3, 3];
        long j = 1;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = number;
                indexes[row, col] = j;
                number++;
                j++;
            }
        }
      
        long numberValue = board[y, x];
        long numberIndex = indexes[y, x];
        long result = (long)Math.Pow(numberValue, numberIndex);
        Console.WriteLine(result);

    }
}
