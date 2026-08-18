using System;

class Program
{
    static void Main()
    {
        double p1 = 6.5;
        double p2 = 7.0;
        double p3 = 5.5;

        Console.WriteLine(media(p1, p2, p3));
    }

    public static double media(double p1, double p2, double p3)
    {
        return (p1 + p2 + p3) / 3;
    }
}   