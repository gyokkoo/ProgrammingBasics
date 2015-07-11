using System;

class BitPaths
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] bits = new int[8];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int pos = 3 - int.Parse(numbers[0]);

            bits[0] = bits[0] ^ (1 << pos); // 0000^0010 = 0010

            for (int j = 1; j < bits.Length; j++)
            {
                int currentOffset = int.Parse(numbers[j]);
                pos -= currentOffset;
                bits[j] = bits[j] ^ (1 << pos);
            }
        }
        int sum = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            sum += bits[i];
        }

        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}", sum);
    }
}
