using System;
class BitPaths
{
    static void Main()
    {
        int[,] board = new int[8, 4];
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                board[row, col] = 0;
            }
        }

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputSplitted = input.Split(',');
            string start = inputSplitted[0];
            int col = 0;
#region start
            if (start == "0")
            {
                if(board[0,0] == 0)
                {
                    board[0, 0] = 1;
                }
                else
                {
                    board[0,0] = 0;
                }
                col = 0;
            }
            else if (start == "1")
            {
                if(board[0,1] == 0)
                {
                     board[0, 1] = 1;
                }
                else 
                {
                    board[0,1] = 0;
                }
                col = 1;
            }
            else if (start == "2")
            {
                if(board[0,2] == 0)
                {
                     board[0, 2] = 1;
                }
                else
                {
                    board[0,2] = 0;
                }
                col = 2;
            }
            else if (start == "3")
            {
                if(board[0,3] == 0)
                {
                     board[0, 3] = 1;
                }
                else
                {
                    board[0,3] = 0;
                }
                col = 3;
            }
#endregion
            for (int j = 1; j < inputSplitted.Length; j++)
            {
                string cor = inputSplitted[j];

                if (cor == "0")
                {
                    if (board[j, col] == 0)
                    {
                        board[j, col] = 1;
                    }
                    else
                    {
                        board[j, col] = 0;
                    }
                }
                else if (cor == "+1")
                {
                    if (board[j, col + 1] == 0)
                    {
                        board[j, col + 1] = 1;
                    }
                    else
                    {
                        board[j, col + 1] = 0;
                    }
                    col = col + 1;
                }
                else if (cor == "-1")
                {
                    if (board[j, col - 1] == 0)
                    {
                        board[j, col - 1] = 1;
                    }
                    else
                    {
                        board[j, col - 1] = 0;
                    }
                    col = col - 1;
                }
            } 
        }

        string result = "";
        int sum = 0;
        int intResult = 0;
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                result += (board[row, col] + "");
            }
            intResult = Convert.ToInt32(result, 2);
            sum += intResult;
            result = "";
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine(sum.ToString("X"));
    }
}
