using System;

class Program
{
    static void Main()
    {
        int idade = 15;

        verificarIdade(idade);
    }

    public static void verificarIdade(int idade)
    {
        if (idade < 0)
        {
            Console.WriteLine("Você não nasceu!");
        }
        else if (idade > 0 && idade <= 12)
        {
            Console.WriteLine("Você é uma criança!");
        }
        else if (idade > 12 && idade <= 17)
        {
            Console.WriteLine("Você é um adolescente!");
        }
        else if (idade > 17 && idade <= 59)
        {
            Console.WriteLine("Você é um adulto!");
        }
        else if (idade > 59)
        {
            Console.WriteLine("Você é um idoso!");
        }
    }
}