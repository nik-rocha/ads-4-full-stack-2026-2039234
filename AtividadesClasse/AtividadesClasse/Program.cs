using System;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public double Preco { get; set; }

    public Livro(string titulo, string autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }
}

public class Program
{
    public static void Main()
    {
        var l1 = new Livro("O Livro, 1", "O criador", 25.50);
        Console.Write($"{l1.Titulo} - {l1.Autor}: {l1.Preco}");

        var l2 = new Livro("O Livro, 2", "A criadora", 30.50);
        Console.Write($"\n{l2.Titulo} - {l2.Autor}: {l2.Preco}");
    }
}
