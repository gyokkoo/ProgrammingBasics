using System;
using System.Globalization;

class Numerology
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(' ');

        string date = inputArr[0];
        string[] dateArray = date.Split('.');
        int day = int.Parse(dateArray[0]);
        int month = int.Parse(dateArray[1]);
        int year = int.Parse(dateArray[2]);

        string username = inputArr[1];

        double celestialNumber = 0;

        celestialNumber = day * month * year;

        if(month % 2 == 1)
        {
            celestialNumber *= celestialNumber;
        }

        char[] ch = username.ToCharArray();
        int usernameSum = 0;
        for (int i = 0; i < ch.Length; i++)
        {
            if(ch[i] >= 'A' && ch[i]<= 'Z')
            {
                usernameSum += 2*((int)ch[i]-64);
            } 
            else if(ch[i] >= 'a' && ch[i] <= 'z')
            {
                usernameSum += ((int)ch[i] - 96);
            }
            else if(ch[i] >= '0' && ch[i] <= '9')
            {
                usernameSum += ((int)ch[i] - 48);
            }
        }
        celestialNumber += usernameSum;
        long digitSum = 0;
        while (celestialNumber > 13)
        {
            long n = (long)celestialNumber;
            digitSum = 0;
            while (n != 0)
            {
                digitSum += n % 10;
                n /= 10;
            }
            celestialNumber = digitSum;
        }
        Console.WriteLine(celestialNumber);
    }
}