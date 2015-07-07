using System;

class PandaScotlandFlag
{
    static void Main()
    {
        char currChar = 'A';
        int n = int.Parse(Console.ReadLine());
        int tilda = 1;
        int sharp = n - 4;

        if (n == 1)
        {
            Console.WriteLine("A");
        }
        else if (n == 3)
        {
            Console.WriteLine("A#B");
            Console.WriteLine("-C-");
            Console.WriteLine("D#E");
        }
        else
        {   
            Console.WriteLine(currChar++ + new string('#', n - 2) + currChar++);

            if (currChar == 'Z' + 1)
                currChar = 'A';
            for (int i = 0; i < n / 2 - 1; i++)
            {
                if (currChar == 'Z' + 1)
                    currChar = 'A';
                Console.Write("{0}{1}{2}", new string('~', tilda), currChar++, new string('#', sharp));
                if (currChar == 'Z' + 1)
                    currChar = 'A';
                Console.WriteLine("{0}{1}", currChar++, new string('~', tilda));
                tilda++;
                sharp -= 2;

            }
            if (currChar == 'Z' + 1)
                currChar = 'A';
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2),   currChar++   );
            if (currChar == 'Z' + 1)
                currChar = 'A';
            for (int i = 0; i < n / 2 - 1; i++)
            {
                if (currChar == 'Z' + 1)
                    currChar = 'A';
                tilda--;
                sharp += 2;
                Console.Write("{0}{1}{2}", new string('~', tilda), currChar++, new string('#', sharp));
                if (currChar == 'Z' + 1)
                    currChar = 'A';
                Console.WriteLine("{0}{1}", currChar++, new string('~', tilda));
            }
            if (currChar == 'Z' + 1)
                currChar = 'A';
            Console.WriteLine(currChar++ + new string('#', n - 2) + currChar++);
        }
    }
}