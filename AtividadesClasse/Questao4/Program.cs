using System;

public class Funcionario
{
    public double Salario {  get; set; }

    public Funcionario(double salario)
    {
        Salario = salario;
    }

    public virtual double CalcularBonus()
    {
        return 0;
    }
}

public class Gerente : Funcionario
{
    public Gerente(double salario) : base(salario)
    {
        Salario = salario;
    }

    public override double CalcularBonus()
    {
        return Salario * 0.1 ;
    }
}

public class Program
{
    public static void Main()
    {
        var g1 = new Gerente(8500.00);
    }
}
