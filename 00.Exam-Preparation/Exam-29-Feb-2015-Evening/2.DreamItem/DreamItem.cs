using System;
class DreamItem
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split('\\');
        string month = "";
        decimal moneyPerHour = 0;
        int hoursPerDay = 0;
        decimal itemPrice = 0;
        for (int i = 0; i < 4; i++)
        {
            month = inputArray[0];
            moneyPerHour = decimal.Parse(inputArray[1]);
            hoursPerDay = int.Parse(inputArray[2]);
            itemPrice = decimal.Parse(inputArray[3]);
        }
        int workingDays = 0; 
        if(month == "Jan" || month == "Mar" || month == "March"|| month == "May" || month == "July" || month == "Aug" || month == "Oct" || month == "Dec")
        {
            workingDays = 21;
        }
        else if(month == "Feb")
        {
            workingDays = 18;
        }
        else if(month == "Apr" || month == "June" || month == "Sept" || month == "Nov")
        {
            workingDays = 20;
        }

        decimal salary = workingDays * moneyPerHour * hoursPerDay;
        if (salary >= 700)
        {
            salary +=  salary*(decimal)0.1;
        }
        
        if (salary  >= itemPrice)
        {
            decimal diff = salary - itemPrice;
            Console.WriteLine("Money left = {0:F2} leva.", diff);
        }
        else
        {
            decimal diff = itemPrice - salary;
            Console.WriteLine("Not enough money. {0:F2} leva needed.", diff);
        }
    }
}