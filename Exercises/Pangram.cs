using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // throw new NotImplementedException();

        string data = "abcdefghijklmnopqrstuvwxyz";
        char[] letterArray = data.ToCharArray();
        bool boolCheck = false;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < letterArray.Length; j++)
            {
                if (input[i] == letterArray[j]) i++;
            }

            if (i == data.Length-1) boolCheck = true;
        }

        return boolCheck;
    }
}