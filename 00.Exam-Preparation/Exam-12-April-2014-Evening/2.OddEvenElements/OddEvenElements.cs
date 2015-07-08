using System;
class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        string line = Console.ReadLine();
        string[] numbers = line.Split(' ');
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        if (line == "")
        {
            numbers = new string[0];
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            decimal curNum = decimal.Parse(numbers[i]);
            if ((i + 1) % 2 == 1)
            {
                oddSum += curNum;
                if (curNum <= oddMin)
                {
                    oddMin = curNum;
                }
                if (curNum >= oddMax)
                {
                    oddMax = curNum;
                }
            }
            else
            {
                evenSum += curNum;
                if (curNum <= evenMin)
                {
                    evenMin = curNum;
                }
                if (curNum >= evenMax)
                {
                    evenMax = curNum;
                }
            }
        }
        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}
