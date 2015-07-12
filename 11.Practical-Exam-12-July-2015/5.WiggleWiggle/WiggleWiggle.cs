using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                long num1 = long.Parse(inputArray[i]);
                string num1AsString = Convert.ToString(num1, 2).PadLeft(63, '0');
                char[] ch1 = num1AsString.ToCharArray();

                long num2 = long.Parse(inputArray[i + 1]);
                string num2AsString = Convert.ToString(num2, 2).PadLeft(63, '0');
                char[] ch2 = num2AsString.ToCharArray();
         
                char temp1;
                char temp2;
                for (int j = 0; j < ch1.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        temp1 = ch1[j];
                        temp2 = ch2[j];

                        ch1[j] = temp2;
                        ch2[j] = temp1;
                    }
                }

                string num1string = new string(ch1);
                string num2string = new string(ch2);
                //Console.WriteLine(num1string);
                //Console.WriteLine(num2string);
                //Console.WriteLine(Convert.ToString(long.MaxValue,2));
                //Console.WriteLine(Convert.ToInt64(num1string,2));
                //Console.WriteLine(Convert.ToInt64(num2string,2));

                char[] tildaArr1 = num1string.ToCharArray();
                for (int a = 0; a < tildaArr1.Length; a++)
                {
                    if (tildaArr1[a] == '1')
                    {
                        tildaArr1[a] = '0';
                    }
                    else if (tildaArr1[a] == '0')
                    {
                        tildaArr1[a] = '1';
                    }
                }

                char[] tildaArr2 = num2string.ToCharArray();
                for (int b = 0; b < tildaArr2.Length; b++)
                {
                    if (tildaArr2[b] == '1')
                    {
                        tildaArr2[b] = '0';
                    }
                    else if (tildaArr2[b] == '0')
                    {
                        tildaArr2[b] = '1';
                    }
                }

                //foreach (char symbol in tildaArr1)
                //{
                //    Console.Write(symbol);
                //}
                //Console.WriteLine();
                //foreach (char symbol in tildaArr2)
                //{
                //    Console.Write(symbol);
                //}
                //Console.WriteLine();

                string tilda1 = new string(tildaArr1);
                string tilda2 = new string(tildaArr2);

                num1 = Convert.ToInt64(tilda1, 2);
                num2 = Convert.ToInt64(tilda2, 2);

                Console.Write(num1);
                Console.Write(" ");
                Console.WriteLine(Convert.ToString(num1, 2).PadLeft(63, '0'));
                Console.Write(num2);
                Console.Write(" ");
                Console.WriteLine(Convert.ToString(num2, 2).PadLeft(63, '0'));

                i++;
            }
        }
    }
}
