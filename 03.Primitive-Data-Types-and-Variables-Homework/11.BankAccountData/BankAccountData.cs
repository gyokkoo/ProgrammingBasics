using System;
/*
 A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the 
 information for a single bank account using the appropriate data types and descriptive names.
 */
class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petkov";
        string lastName = "Ivanov";
        decimal balance = 1500M; //M is the suffix for decimal numbers 
        string bankName = "Bank of America";
        string iban = "BG80 BNBG 9661 1020 3456 78";
        ulong firstCreditCard = 38126933311267u;
        ulong secondCreditCard = 30178427061963u;
        ulong thirdCreditCard = 30119302334992u;
        Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0:C}", balance);
        Console.WriteLine("Bank's name: {0}", bankName);
        Console.WriteLine("IBAN number: {0}", iban);
        Console.WriteLine("First Credit Card : {0}", firstCreditCard);
        Console.WriteLine("Second Credit Card: {0}", secondCreditCard);
        Console.WriteLine("Third Credit Card : {0}", thirdCreditCard);
    }
}

