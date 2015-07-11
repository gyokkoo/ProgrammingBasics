using System;

class JumpingSums
{
    static void Main()
    {
        string input = Console.ReadLine();     
        int jumps = int.Parse(Console.ReadLine());

        string[] inputArray = input.Split(' ');
        int sum = 0;
        int maxSum = 0;
        int number = 0;
        for (int index = 0; index < inputArray.Length; index++)
        {
            sum = 0;
            for (int j = 0; j <= jumps; j++)
            {
                if (j == 0)
                {
                    number = int.Parse(inputArray[index]);
                }
                else
                {
                    number = int.Parse(inputArray[(index + sum)  % (inputArray.Length)]);
                }
                sum = sum + number;
            }
            if(sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("max sum = " + maxSum);
    }
}