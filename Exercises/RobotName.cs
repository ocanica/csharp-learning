using System;

public class Robot
{
    public string Name
    {
        get
        {
            return _alpha + _num.ToString();
        }
    }

    private static string RandAlpha()
    {
        Random rng = new Random();
        string output = "";
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        for (int i = 0; i < 2; i++)
        {
            output += chars[rng.Next(chars.Length)];
        }

        return output.ToString();
    }

    public void Reset()
    {
        _num = new Random().Next(000, 999);
        _alpha = RandAlpha();
    }

    private int _num = new Random().Next(000,999);
    private static string _alpha = RandAlpha();
}