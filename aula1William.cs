// Publico e privado
public class Animal
{
    private int Idade { get; private set; };
    public string Nome;

    public void AlterarIdade(int idadeNova)
    {
        this.Idade = idadeNova;
    }

    public virtual string Barulho()
    {
        return "";
    }
}

// Polimorfismo
public class Gato : Animal
{
    public override string Barulho()
    {
        return "MIAU!!!";
    }

    public void AlterarIdade(int idadeNova)
    {
        this.Idade = idadeNova;
    }
}

public class Cachorro : Animal
{
    public override string Barulho()
    {
        return "AUAU!!!";
    }
}

Animal novoAnimal = new Animal();
int idade = novoAnimal.idade;
novoAnimal.nome = "Cleitinho"