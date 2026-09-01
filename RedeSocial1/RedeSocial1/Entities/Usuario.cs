using Microsoft.AspNetCore.Mvc;

namespace RedeSocial1.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tag { get; set; }
        public string Senha { get; set; }

        public Usuario(int id, string nome, int idade, string tag, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Tag = tag;
            this.Senha = senha;
        }
    }
}
