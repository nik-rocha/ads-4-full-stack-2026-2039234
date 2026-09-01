using System;

public class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Retangulo(double r_base, double altura)
    {
        Base = r_base;
        Altura = altura;
    }

    public double getArea()
    {   
        return Base * Altura;
    }
}

public class Program
{
    public static void Main()
    {
        var r1 = new Retangulo(3.5, 2.0);
        Console.WriteLine(r1.getArea());
    }
}
