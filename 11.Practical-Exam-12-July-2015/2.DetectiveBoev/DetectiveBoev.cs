using System;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMessage = Console.ReadLine();

        char[] secretWordArr = secretWord.ToCharArray();
        int codeSum = 0;
        for (int i = 0; i < secretWordArr.Length; i++)
        {
            codeSum += secretWord[i];
        }
        int mask = codeSum;

        while (mask >= 10)
        {
            int n = mask;
            int maskDigitSum = 0;
            while (n != 0)
            {
                maskDigitSum += n % 10;
                n = n / 10;
            }
            mask = maskDigitSum;
        }

        //Console.WriteLine(mask);
        char[] messageArray = encryptedMessage.ToCharArray();
        for (int i = 0; i < messageArray.Length; i++)
        {
            if (messageArray[i] % mask == 0)
            {
                messageArray[i] = (char)(messageArray[i] + mask);
            }
            else
            {
                messageArray[i] = (char)(messageArray[i] - mask);
            }
        }
        Array.Reverse(messageArray);
        string decruptedMessage = new string(messageArray);
        Console.WriteLine(decruptedMessage);
    }
}
