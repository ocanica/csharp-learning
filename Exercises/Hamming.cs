using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int count = 0;
        int distance = 0;

        foreach (char letter in firstStrand)
        {
            if (letter != secondStrand[count]) distance++;
            count++;
        }

        return distance;
    }
}