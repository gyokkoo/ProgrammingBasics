using System;
class Program
{
    static void Main()
    {
        string firstPlayerName = Console.ReadLine();
        int roundsN = int.Parse(Console.ReadLine());
        string nextPlayer = "";

        int simeonPoints = 0;
        int nakovPoints = 0;

        int roundCounter = 1;

        for (int i = 1; i <= roundsN; i++)
        {
            if (firstPlayerName == "Simeon")
            {
                nextPlayer = "Nakov";
                int tryToScorePoints = int.Parse(Console.ReadLine());
                string I = Console.ReadLine(); //fail or success
                if (I == "success" || I == "Success")
                {
                    if (simeonPoints + tryToScorePoints <= 500)
                    {
                        simeonPoints = simeonPoints + tryToScorePoints;
                        if (simeonPoints == 500)
                        {
                            Console.WriteLine("Simeon");
                            Console.WriteLine(roundCounter);
                            Console.WriteLine(nakovPoints);
                            break;
                        }
                    }
                }
                if (nextPlayer == "Nakov")
                {
                    int tryToScorePointsSecond = int.Parse(Console.ReadLine()); //
                    string I2 = Console.ReadLine(); //fail or success
                    if (I2 == "success" || I2 == "Success")
                    {
                        if (nakovPoints + tryToScorePointsSecond <= 500)
                        {
                            nakovPoints = nakovPoints + tryToScorePointsSecond;
                            if (nakovPoints == 500)
                            {
                                Console.WriteLine("Nakov");
                                Console.WriteLine(roundCounter);
                                Console.WriteLine(simeonPoints);
                                break;
                            }
                        }
                    }
                    firstPlayerName = "Nakov";
                }

            }
            else if (firstPlayerName == "Nakov")
            {
                nextPlayer = "Simeon";
                int tryToScorePoints = int.Parse(Console.ReadLine()); //
                string I = Console.ReadLine(); //fail or success
                if (I == "success" || I == "Success")
                {
                    if (nakovPoints + tryToScorePoints <= 500)
                    {
                        nakovPoints = nakovPoints + tryToScorePoints;
                        if (nakovPoints == 500)
                        {
                            Console.WriteLine("Nakov");
                            Console.WriteLine(roundCounter);
                            Console.WriteLine(simeonPoints);
                            break;
                        }
                    }
                }
                if (nextPlayer == "Simeon")
                {
                    int tryToScorePoints2 = int.Parse(Console.ReadLine()); //
                    string I2 = Console.ReadLine(); //fail or success
                    if (I2 == "success" || I2 == "Success")
                    {
                        if (simeonPoints + tryToScorePoints2 <= 500)
                        {
                            simeonPoints = simeonPoints + tryToScorePoints2;
                            if (simeonPoints == 500)
                            {
                                Console.WriteLine("Simeon");
                                Console.WriteLine(roundCounter);
                                Console.WriteLine(nakovPoints);
                                break;
                            }
                        }
                    }
                }
                firstPlayerName = "Simeon";
            }
            roundCounter++;
        }


        if (simeonPoints == nakovPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(simeonPoints);
        }
        else if (simeonPoints != 500 && nakovPoints != 500)
        {
            Console.WriteLine("{0}", simeonPoints > nakovPoints ? "Simeon" : "Nakov");
            Console.WriteLine("{0}", simeonPoints > nakovPoints ? simeonPoints - nakovPoints : nakovPoints - simeonPoints);
        }
    }
}
