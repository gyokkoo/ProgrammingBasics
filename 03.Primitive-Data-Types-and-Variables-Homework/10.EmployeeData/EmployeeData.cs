using System;
/*
 A marketing company wants to keep record of its employees. Each record would have the following characteristics: 
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.
 */
class EmployeeData
{
    static void Main()
    {
        string firstName = "Amanda";
        string lastName = "Janson";
        byte age = 27;
        char gender = 'f';
        string personalID = "8306112507";
        string employeeNumber = "27563571";
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", personalID);
        Console.WriteLine("Unique Employee number: {0}", employeeNumber);
    }
}

