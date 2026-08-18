using System;

class Program
{
    static void Main()
    {
        int num = 2;

        tabuada(num);
    }

    public static void tabuada(int n)
    {
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(n * i);
        }
    }
}