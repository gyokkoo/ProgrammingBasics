using System;
using System.Collections.Generic;

class EncryptTheMessages
{
    static void Main()
    {
        string input = "";
        List<string> messages = new List<string>();
        int messagesCounter = 0;
        while (true)
        {
            if (input == "START" || input == "start")
            {
                input = Console.ReadLine();
                while (input != "END" && input != "end")
                {
                    char[] letters = input.ToCharArray();
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if ((int)letters[i] >= 65 && (int)letters[i] <= 77)
                        {
                            letters[i] = (char)((int)letters[i] + 13);
                        }
                        else if ((int)letters[i] >= 78 && (int)letters[i] <= 90)
                        {
                            letters[i] = (char)((int)letters[i] - 13);
                        }
                        else if ((int)letters[i] >= 97 && (int)letters[i] <= 109)
                        {
                            letters[i] = (char)((int)letters[i] + 13);
                        }
                        else if ((int)letters[i] >= 97 && (int)letters[i] <= 122)
                        {
                            letters[i] = (char)((int)letters[i] - 13);
                        }
                        else if (letters[i] == ' ')
                        {
                            letters[i] = '+';
                        }
                        else if (letters[i] == ',')
                        {
                            letters[i] = '%';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == '?')
                        {
                            letters[i] = '#';
                        }
                        else if (letters[i] == '!')
                        {
                            letters[i] = '$';
                        }
                    }
                    Array.Reverse(letters);
                    string message = new string(letters);
                    if (input != string.Empty)
                    {
                        messages.Add(message);
                        messagesCounter++;
                    }
                    input = Console.ReadLine();
                    if (input == "END" || input == "end")
                    {
                        break;
                    }
                }
                break;
            }
            else
            {
                input = Console.ReadLine();
            }
        }
        if (messagesCounter == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", messagesCounter);
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

    }
}