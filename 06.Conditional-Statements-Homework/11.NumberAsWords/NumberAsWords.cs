using System;
/*
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
Examples:
numbers	number as words
0   	Zero
9	    Nine
10	    Ten
12      Twelve
19	    Nineteen
 */
class NumberAsWords
{
    static void Main()
    {
        Console.Title = "Problem 11.	* Number as Words";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter a number in the range [0..999]");
        Console.Write("number = ");
        int number = int.Parse(Console.ReadLine());
        int units = number % 10; //Takes the first digit.
        int tens = (number / 10) % 10; // Takes the second digit.
        int hundreds = number / 100; //Takes the third digit.
        int subHundreds = number % 100; //Takes the last two digits.
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        if (number <= 999 && number >= 0)
        {
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (hundreds != 0)
            {
                if (tens == 0 && units == 0)
                {
                    switch (hundreds)
                    {
                        case 1: Console.WriteLine("One hundred"); break;
                        case 2: Console.WriteLine("Two hundred"); break;
                        case 3: Console.WriteLine("Three hundred"); break;
                        case 4: Console.WriteLine("Four hundred"); break;
                        case 5: Console.WriteLine("Five hundred"); break;
                        case 6: Console.WriteLine("Six hundred"); break;
                        case 7: Console.WriteLine("Seven hundred"); break;
                        case 8: Console.WriteLine("Eight hundred"); break;
                        case 9: Console.WriteLine("Nine hundred"); break;
                    }
                }
                else
                {
                    switch (hundreds)
                    {
                        case 1: Console.Write("One hundred and "); break;
                        case 2: Console.Write("Two hundred and "); break;
                        case 3: Console.Write("Three hundred and "); break;
                        case 4: Console.Write("Four hundred and "); break;
                        case 5: Console.Write("Five hundred and "); break;
                        case 6: Console.Write("Six hundred and "); break;
                        case 7: Console.Write("Seven hundred and "); break;
                        case 8: Console.Write("Eight hundred and "); break;
                        case 9: Console.Write("Nine hundred and "); break;
                    }
                    if (subHundreds >= 1 && subHundreds <= 19)
                    {
                        switch (subHundreds)
                        {
                            case 1: Console.WriteLine("one"); break;
                            case 2: Console.WriteLine("two"); break;
                            case 3: Console.WriteLine("three"); break;
                            case 4: Console.WriteLine("four"); break;
                            case 5: Console.WriteLine("five"); break;
                            case 6: Console.WriteLine("six"); break;
                            case 7: Console.WriteLine("seven"); break;
                            case 8: Console.WriteLine("eight"); break;
                            case 9: Console.WriteLine("nine"); break;
                            case 10: Console.WriteLine("ten"); break;
                            case 11: Console.WriteLine("eleven"); break;
                            case 12: Console.WriteLine("twelve"); break;
                            case 13: Console.WriteLine("thirteen"); break;
                            case 14: Console.WriteLine("fourteen"); break;
                            case 15: Console.WriteLine("fiveteen"); break;
                            case 16: Console.WriteLine("sixteen"); break;
                            case 17: Console.WriteLine("seventeen"); break;
                            case 18: Console.WriteLine("eighteen"); break;
                            case 19: Console.WriteLine("nineteen"); break;
                        }
                    }
                    else if (tens >= 2)
                    {
                        if (units == 0)
                        {
                            switch (tens)
                            {
                                case 2: Console.WriteLine("twenty"); break;
                                case 3: Console.WriteLine("thirty"); break;
                                case 4: Console.WriteLine("forty"); break;
                                case 5: Console.WriteLine("fifty"); break;
                                case 6: Console.WriteLine("sixty"); break;
                                case 7: Console.WriteLine("seventy"); break;
                                case 8: Console.WriteLine("eighty"); break;
                                case 9: Console.WriteLine("ninety"); break;
                            }
                        }
                        else
                        {
                            switch (tens)
                            {
                                case 2: Console.Write("twenty "); break;
                                case 3: Console.Write("thirty "); break;
                                case 4: Console.Write("forty "); break;
                                case 5: Console.Write("fifty "); break;
                                case 6: Console.Write("sixty "); break;
                                case 7: Console.Write("seventy "); break;
                                case 8: Console.Write("eighty "); break;
                                case 9: Console.Write("ninety "); break;
                            }

                            switch (units)
                            {
                                case 1: Console.WriteLine("one"); break;
                                case 2: Console.WriteLine("two"); break;
                                case 3: Console.WriteLine("three"); break;
                                case 4: Console.WriteLine("four"); break;
                                case 5: Console.WriteLine("five"); break;
                                case 6: Console.WriteLine("six"); break;
                                case 7: Console.WriteLine("seven"); break;
                                case 8: Console.WriteLine("eight"); break;
                                case 9: Console.WriteLine("nine"); break;
                            }

                        }

                    }
                }
            }
            else if (hundreds == 0 && units != 0)
            {
                if (tens >= 2)
                {
                    switch (tens)
                    {
                        case 2: Console.Write("Twenty "); break;
                        case 3: Console.Write("Thirty "); break;
                        case 4: Console.Write("Forty "); break;
                        case 5: Console.Write("Fifty "); break;
                        case 6: Console.Write("Sixty "); break;
                        case 7: Console.Write("Seventy "); break;
                        case 8: Console.Write("Eighty "); break;
                        case 9: Console.Write("Ninety "); break;
                    }

                    switch (units)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                    }
                }
                else if (tens <= 1)
                {
                    switch (subHundreds)
                    {
                        case 1: Console.WriteLine("One"); break;
                        case 2: Console.WriteLine("Two"); break;
                        case 3: Console.WriteLine("Three"); break;
                        case 4: Console.WriteLine("Four"); break;
                        case 5: Console.WriteLine("Five"); break;
                        case 6: Console.WriteLine("Six"); break;
                        case 7: Console.WriteLine("Seven"); break;
                        case 8: Console.WriteLine("Eight"); break;
                        case 9: Console.WriteLine("Nine"); break;
                        case 10: Console.WriteLine("Ten"); break;
                        case 11: Console.WriteLine("Eleven"); break;
                        case 12: Console.WriteLine("Twelve"); break;
                        case 13: Console.WriteLine("Thirteen"); break;
                        case 14: Console.WriteLine("Fourteen"); break;
                        case 15: Console.WriteLine("Fiveteen"); break;
                        case 16: Console.WriteLine("Sixteen"); break;
                        case 17: Console.WriteLine("Seventeen"); break;
                        case 18: Console.WriteLine("Eighteen"); break;
                        case 19: Console.WriteLine("Nineteen"); break;
                    }
                }

            }
            else if (hundreds == 0 && units == 0)
            {
                switch (tens)
                {
                    case 2: Console.WriteLine("Twenty"); break;
                    case 3: Console.WriteLine("Thirty"); break;
                    case 4: Console.WriteLine("Forty"); break;
                    case 5: Console.WriteLine("Fifty"); break;
                    case 6: Console.WriteLine("Sixty"); break;
                    case 7: Console.WriteLine("Seventy"); break;
                    case 8: Console.WriteLine("Eighty"); break;
                    case 9: Console.WriteLine("Ninety"); break;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid number, not in the range [0..999]");
        }
		Console.ReadKey();
    }
}