using System;

class PogrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        char[] ch = input.ToCharArray();
        char curChar = ch[0];

        int fullDiamond = n / 7;
        int halfDiamond = n % 7;
        int outDots = 3;

        for (int i = 0; i < fullDiamond; i++)
        {
            #region fullDiamond
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!

            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                 if (curChar - 1 == (int)'G') curChar = 'A';
                 Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 2!

            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line3!

            for (int a = 0; a < 7; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine();
            //end line4! - middle line

            outDots = 1;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots++;
            //end line5! 

            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots++;
            //end line6!

            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            Console.WriteLine(new string('.', outDots));
            outDots++;
            //end line7!
            #endregion
        }

        if (halfDiamond == 1)
        {
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!
        }
        else if (halfDiamond == 2)
        {
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 2!
        }
        else if (halfDiamond == 3)
        {
            #region halfDiamond 3
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 2!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 3!
            #endregion
        }
        else if (halfDiamond == 4)
        {
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 2!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 3!
            for (int a = 0; a < 7; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine();
            //end line 4!
        }
        else if (halfDiamond == 5)
        {
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 2!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 3!
            for (int a = 0; a < 7; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine();
            //end line 4!
            outDots = 1;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots++;
            //end line 5
        }
        else if (halfDiamond == 6)
        {
            outDots = 3;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(curChar++);
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 1!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 2!
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots--;
            //end line 3!
            for (int a = 0; a < 7; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine();
            //end line 4!
            outDots = 1;
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 5; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots++;
            //end line 5
            if (curChar - 1 == (int)'G') curChar = 'A';
            Console.Write(new string('.', outDots));
            for (int a = 0; a < 3; a++)
            {
                if (curChar - 1 == (int)'G') curChar = 'A';
                Console.Write(curChar++);
            }
            Console.WriteLine(new string('.', outDots));
            outDots++;
            //end line6!
        }
    }
}
