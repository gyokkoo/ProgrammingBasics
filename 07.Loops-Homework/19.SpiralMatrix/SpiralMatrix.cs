using System;
/*
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix
holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 
Examples:
n	matrix		
2	1 2     
    4 3		
 */
class SpiralMatrix
{
	int n = int.Parse(Console.ReadLine());
	int[,] matrix = new int[n, n];
	int row = 0;
	int col = n - 1;
	int limit = n - 1;
	int limitCount = 0;
	bool signPlus = true;
	bool changeRow = true;
	int changeSign = 1;
	int decreaseLimit = 0;


	if (n >= 1 && n <= 20)
	{

		for (int i = 0; i < n; i++)
		{
			matrix[row, i] = i + 1;
		}

		for (int i = n + 1; i <= n * n; i++)
		{
			if (changeRow == true && signPlus == true)
			{
				row++;
			}
			else if (changeRow == true && signPlus == false)
			{
				row--;
			}
			else if (changeRow == false && signPlus == true)
			{
				col++;
			}
			else
			{
				col--;
			}

			matrix[row, col] = i;
			limitCount++;

			if (limitCount >= limit)
			{
				changeRow = !changeRow;
				limitCount = 0;
				changeSign++;
				decreaseLimit++;

				if (changeSign % 2 == 0)
				{
					signPlus = !signPlus;
					changeSign = 0;
				}

				if (decreaseLimit % 2 == 0)
				{
					limit--;
				}

			}
		}


		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0,-4}", matrix[i, j]);
			}
			Console.WriteLine();
		}
	}
}