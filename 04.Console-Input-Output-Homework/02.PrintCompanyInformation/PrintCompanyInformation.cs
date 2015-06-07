using System;
/*
 A company has name, address, phone number, fax number, web site and manager. 
 The manager has first name, last name, age and a phone number. Write a program that reads 
 the information about a company and its manager and prints it back on the console. 
 */
class PrintCompanyInformation
{
    static void Main()
    {
        string[] companyDetails = new string[] { "name", "address", "phone number", "fax number", "website", "manager's first name", "manager's last name", "manager's age", "manager's phone number" };        
        string[] companyInformation = new string[companyDetails.Length];
        for (int i = 0; i < companyInformation.Length; i++)
        {
            Console.WriteLine("Please enter the company's {0}.", companyDetails[i]);
            companyInformation[i] = Console.ReadLine();
        }
        for (int i = 0; i < companyInformation.Length; i++)
        {
            Console.WriteLine("Company {0,-25}| {1,-25}", companyDetails[i], companyInformation[i]);
        }
    }
}

