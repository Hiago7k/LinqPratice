
namespace LinqPratice;

abstract class Produtos
{
    public Produtos(string nome, int preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome { get; }
    public int Preco { get; }


    public virtual void ExibirDados()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Preco);
    }
}
