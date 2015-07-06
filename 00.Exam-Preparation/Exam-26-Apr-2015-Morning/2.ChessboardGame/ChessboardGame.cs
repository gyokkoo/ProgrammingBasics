using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        char[] ch = input.ToCharArray();

        List<int> numbers = new List<int>();
        for (int i = 0; i < size * size; i++)
        {
            if (i < input.Length)
            {
                if (((int)ch[i] >= 48 && (int)ch[i] <= 57) || ((int)ch[i] <= 90 && (int)ch[i] >= 65) || ((int)ch[i] <= 122 && (int)ch[i] >= 97))
                {
                    numbers.Add((int)ch[i]);
                }
                else
                {
                    numbers.Add(0);
                }
            }
            else
            {
                numbers.Add(0);
            }
        }
        int whiteScore = 0;
        int blackScore = 0;

        int[,] chessboard = new int[size, size];
        int a = 0;
        string squareColor = "black";
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                chessboard[row, col] = numbers[a];
                a++;
                if (squareColor == "black")
                {
                    if (chessboard[row, col] >= 65 && chessboard[row, col] <= 90)
                    {
                        whiteScore += chessboard[row, col];
                    }
                    else
                    {
                        blackScore += chessboard[row, col];
                    }
                    squareColor = "white";
                }
                else if (squareColor == "white")
                {

                    if (chessboard[row, col] >= 65 && chessboard[row, col] <= 90)
                    {
                        blackScore += chessboard[row, col];
                    }
                    else
                    {
                        whiteScore += chessboard[row, col];
                    }
                    squareColor = "black";
                }

            }
        }
        //for (int row = 0; row < size; row++)
        //{
        //    for (int col = 0; col < size; col++)
        //    {
        //        Console.Write(chessboard[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}
        if (whiteScore > blackScore)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteScore - blackScore);
        }
        else if (blackScore > whiteScore)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackScore - whiteScore);
        }
        else
        {
            Console.WriteLine("Equal result: {0}", blackScore);
        }
    }
}