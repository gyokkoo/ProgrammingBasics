using System;

/*Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years. */
class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthdate in format dd/mm/yyyy!");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthdate.Year;
        if (birthdate.Month > today.Month || (birthdate.Month >= today.Month && birthdate.Day > today.Day))
        {
            Console.WriteLine("Your age now is {0}, after 10 years your age will be {1}", age - 1, age + 9);
        }
        else
        {
            Console.WriteLine("Your age now is {0}, after 10 years your age will be {1}", age, age + 10);
        }
    }
}