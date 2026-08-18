using System;

class Program
{
    static void Main()
    {
        double fahrenheuit = 98.6;

        Console.WriteLine(converterC(fahrenheuit));
    }

    public static double converterC(double temp)
    {
        return (temp - 35) * 5 / 9;
    }
}