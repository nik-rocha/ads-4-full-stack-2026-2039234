using System;

public class ContaBancaria
{
    public string Conta { get; set; }
    private double saldo;
    public double Saldo
    {
        get { return saldo; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Valores nulos não são aceitos");
            }

            saldo = value;
        }
    }

    public ContaBancaria(string conta, double saldo)
    {
        Conta = conta;
        Saldo = saldo;
    }
}

public class Program
{
    public static void Main()
    {
        var c1 = new ContaBancaria("Carlos", -1500.00);
    }
}
