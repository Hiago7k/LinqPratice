
namespace LinqPratice;

abstract class Produtos
{
    public Produtos(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome { get; }
    public decimal Preco { get; }


    public virtual void ExibirDados()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(Preco);
    }
}
