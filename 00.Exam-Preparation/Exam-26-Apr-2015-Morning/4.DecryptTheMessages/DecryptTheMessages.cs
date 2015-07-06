using System;
using System.Collections.Generic;
class DecryptTheMessages
{
    static void Main()
    {
        int messagesCounter = 0;
        List<string> messages = new List<string>();
        string start = "";
        while(true)
        {
            if (start == "start" || start == "START")
            {
                string line = Console.ReadLine();

                while (line != "END" && line != "end")
                {
                    if (line == "" || line == null)
                    {
                        messagesCounter += 0;
                    }
                    else
                    {
                        messagesCounter++;
                    }
                    char[] letters = line.ToCharArray();
                    #region
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
                        else if (letters[i] == '+')
                        {
                            letters[i] = ' ';
                        }
                        else if (letters[i] == '%')
                        {
                            letters[i] = ',';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == '#')
                        {
                            letters[i] = '?';
                        }
                        else if (letters[i] == '$')
                        {
                            letters[i] = '!';
                        }

                    }
                    #endregion
                    Array.Reverse(letters);
                    string message = new string(letters);
                    if (line != string.Empty)
                    {
                        messages.Add(message);
                    }
                    line = Console.ReadLine();
                    if (line == "END" || line == "end")
                    {
                        break;
                    }
                }
                break;
            }
            else
            {
                start = Console.ReadLine();
            }
        }
        if (messagesCounter == 0)
        {
            Console.WriteLine("No message received.");
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

