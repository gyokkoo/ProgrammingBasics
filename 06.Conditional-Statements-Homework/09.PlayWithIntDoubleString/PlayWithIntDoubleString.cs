using System;
/*
Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
If the variable is int or double, the program increases it by one. 
If the variable is a string, the program appends "*" at the end. 
Print the result at the console. Use switch statement. 
 */
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.Title = "Problem 9.	Play with Int, Double and String";
        Console.WriteLine("Please choose a type");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString + "*");
                break;
            default:
                Console.WriteLine("invalid input");
                break;
        }
    }
}