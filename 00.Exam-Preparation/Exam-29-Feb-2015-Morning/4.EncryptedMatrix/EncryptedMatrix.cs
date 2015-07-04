using System;
class EncryptedMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();
        string matrixType = Console.ReadLine();

        char[] ch = input.ToCharArray();
        string digitStr = "";
        for (int i = 0; i < ch.Length; i++)
        {
            int digit = (int)ch[i] % 10;
            if(ch.Length == 1)
            {
                Console.WriteLine(digit);
                break;
            }
            if (digit % 2 == 0 || digit == 0)
            {
                digitStr += digit * digit;
            }
            else
            {
                if (i == 0)
                {
                    digitStr += ((int)ch[i + 1] % 10 + digit);
                }
                else if (i == ch.Length - 1)
                {
                    digitStr += ((int)ch[i- 1] % 10 + digit);
                }
                else
                {
                    digitStr += ((int)ch[i - 1] % 10 + (int)ch[i + 1] % 10 + digit);
                }
            }
        }
        char[]digitChar = digitStr.ToCharArray();
        char[,] matrix = new char [digitChar.Length, digitStr.Length];
       
        if (matrixType == @"\")
        {
            for (int row = 0; row < digitStr.Length; row++)
            {
                for (int col = 0; col < digitStr.Length; col++)
                {
                    matrix[row, col] = '0';
                    if (row == col)
                    {
                        matrix[row, col] = digitChar[col];
                    }
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        else if (matrixType == @"/")
        {
            for (int row = 0; row < digitStr.Length; row++)
            {
                for (int col = 0; col < digitStr.Length; col++)
                {
                    matrix[row, col] = '0';
                    if (row + col == digitChar.Length-1)
                    {
                        matrix[row, col] = digitChar[col];
                    }
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
