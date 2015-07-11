using System;
using System.Linq;
class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        char[] ch = input.ToCharArray();
        bool isFound = false;
        string output = "";
        int counter = 0;
        for (int a = 0; a < ch.Length; a++)
        {
            for (int b = 0; b < ch.Length; b++)
            {
                for (int c = 0; c < ch.Length; c++)
                {
                    for (int d = 0; d < ch.Length; d++)
                    {
                        for (int e = 0; e < ch.Length; e++)
                        {
                            counter++;
                            output += ch[a].ToString() + ch[b].ToString() + ch[c].ToString() + ch[d].ToString() + ch[e].ToString();
                            if (counter - 1 == n)
                            {
                                isFound = true;
                                Console.WriteLine(output + " ");
                            }
                            output = "";
                        }
                    }
                }
            }
        }
        if(!isFound)
        {
            Console.WriteLine("No");
        }
    }
}