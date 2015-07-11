using System;

class WinningNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] ch = input.ToCharArray();
        int letSum = 0;
        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] >= 'a' && ch[i] <= 'z')
            {
                letSum += (ch[i] - 96);
            }
            else if (ch[i] >= 'A' && ch[i] <= 'Z')
            {
                letSum += (ch[i] - 64);
            }
        }
        bool isFound = false;
        for (int i = 0; i < 999999; i++)
        {
            int number = i;
            int firstThreeDigits = number / 1000;
            int secondThreeDigits = number % 1000;

            int a = firstThreeDigits % 10;
            int b = firstThreeDigits / 10 % 10;
            int c = firstThreeDigits / 100;
            int firstProduct = a*b*c;

            int d = secondThreeDigits % 10;
            int e = secondThreeDigits / 10 % 10;
            int f = secondThreeDigits / 100;
            int secondProduct = d*e*f;

            if (firstProduct == secondProduct && firstProduct == letSum)
            {
                Console.WriteLine(firstThreeDigits + "-" + secondThreeDigits);
                isFound = true;
            }
            
        }
        if(!isFound)
        {
            Console.WriteLine("No");
        }
    }
}