using System;
class LettersSymbolsNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumLetters = 0;
        int sumNumbers = 0;
        int sumSymbols = 0;
        int number = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            char[] ch = input.ToCharArray();
            for (int j = 0; j < ch.Length; j++)
            {
                if (ch[j] >= 'a' && ch[j] <= 'z')
                {
                    for (int x = (int)'a'; x <= (int)'z'; x++)
                    {
                        if ((int)ch[j] == x)
                        {
                            sumLetters += (x - 96) * 10;
                            break;
                        }
                    }
                }
                else if (ch[j] >= 'A' && ch[j] <= 'Z')
                {
                    for (int x = (int)'A'; x <= (int)'Z'; x++)
                    {
                        if ((int)ch[j] == x)
                        {
                            sumLetters += (x - 64) * 10;
                            break;
                        }
                    }
                }
                else if (int.TryParse(ch[j].ToString(), out number))
                {
                    sumNumbers += number * 20;
                }
                else if (ch[j] == ' ' || ch[j] == '\t' || ch[j] == '\r' || ch[j] == '\n')
                {
                    sumLetters += 0;
                }
                else 
                {
                    sumSymbols += 200;
                }
            }
        }
        Console.WriteLine(sumLetters);
        Console.WriteLine(sumNumbers);
        Console.WriteLine(sumSymbols);
        //Console.WriteLine((int)'a'); // 97
        //Console.WriteLine((int)'z'); // 122
        //Console.WriteLine((int)'A'); // 65
        //Console.WriteLine((int)'Z'); // 90
    }
}