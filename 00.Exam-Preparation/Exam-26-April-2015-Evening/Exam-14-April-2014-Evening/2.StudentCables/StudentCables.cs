using System;

class StudentCables
{
    static void Main()
    {
        int nCables = int.Parse(Console.ReadLine());
        int sumCables = 0;
        int usableCablesCounter = 0;
        for (int i = 0; i < nCables; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string cableMeasure = Console.ReadLine();
            if (cableMeasure == "meters")
            {
                cableLength *= 100;
            }
            if (cableLength < 20)
            {
                continue;
            }
            sumCables += cableLength;
            usableCablesCounter++;
        }
        sumCables -= (usableCablesCounter-1) * 3;

        int studentCables = sumCables / 504;
        int remainder = sumCables - studentCables*504;
        Console.WriteLine(studentCables);
        Console.WriteLine(remainder);
    }
}