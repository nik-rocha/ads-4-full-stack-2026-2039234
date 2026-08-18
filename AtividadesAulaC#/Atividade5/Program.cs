using System;

class Program
{
    static void Main()
    {
        List<double> notas =
             new List<double> {
             7.5, 9.0, 4.5, 6.0, 8.5
             };

        analisarLista(notas);
    }

    public static void analisarLista(List<double> notas)
    {
        double sum = 0;
        double menor = 0;
        double maior = 0;

        foreach (double n in notas)
        {
            sum += n;
            
        }
    }
}