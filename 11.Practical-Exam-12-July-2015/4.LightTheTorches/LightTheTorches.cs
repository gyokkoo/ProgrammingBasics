using System;

class LightTheTorches
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string lD = Console.ReadLine();
        char[] ch = lD.ToCharArray();
        char[] board = new char[n];

        int currentPos = n / 2;
        int moving = 0;

        for (int i = 0; i < n; i++)
        {
            board[i] = ch[i % ch.Length];
        }
        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] inputArray = input.Split(' ');
            string command = inputArray[0];
            int roomsMoving = int.Parse(inputArray[1]);
            if (command == "LEFT")
            {
                for (int i = 0; i < board.Length; i++)
                {
                    moving = currentPos - roomsMoving > 0 ? currentPos - roomsMoving : 1;
                    if (i == (moving - 1))
                    {
                        if (board[i] == 'L')
                        {
                            board[i] = 'D';
                        }
                        else if (board[i] == 'D')
                        {
                            board[i] = 'L';
                        }
                    }
                }
                currentPos = moving - 1;
            }
            else if (command == "RIGHT")
            {

                for (int i = 0; i < board.Length; i++)
                {
                    moving = currentPos + roomsMoving < board.Length ? currentPos + roomsMoving : board.Length - 1;
                    if (i == (moving + 1))
                    {
                        if (board[i] == 'L')
                        {
                            board[i] = 'D';
                        }
                        else if (board[i] == 'D')
                        {
                            board[i] = 'L';
                        }
                    }
                }
                currentPos = moving + 1;
            }
            input = Console.ReadLine();
        }
        //foreach(char symbol in board)
        //{
        //    Console.Write(symbol);
        //}
        //Console.WriteLine();
        int darkRoomsCounter = 0;
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] == 'D')
            {
                darkRoomsCounter++;
            }
        }
        long prays = darkRoomsCounter * 68L;
        Console.WriteLine(prays);
    }
}