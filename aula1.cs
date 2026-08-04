using System;

namespace Fullstack
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Dog", "M", "AuAu");
            meuCachorro.latir();

            Pitbull meuPitbull = new Pitbull("Ui", "F", "RAWR");
            meuPitbull.latir();
        }
    }

    public class Cachorro 
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Latido { get; set; }

        public Cachorro(string nome, string sexo, string latido) 
        {
            Nome = nome;
            Sexo = sexo;
            Latido = latido;
        }

        public virtual void latir() 
        {
            Console.WriteLine(Latido);
        }
    }

    public class Pitbull : Cachorro
    {

        public Pitbull(string nome, string sexo, string latido) : base(nome, sexo, latido)
        {
        }

        public override void latir()
        {
            Console.WriteLine($"{Nome}: {Latido}");
        }
    }
}