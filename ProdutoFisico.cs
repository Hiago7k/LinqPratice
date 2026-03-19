

namespace LinqPratice;

internal class ProdutoFisico : Produtos 
{
    public ProdutoFisico(string nome, decimal preco,string tipo) : base(nome, preco)
    {
        Tipo = tipo;
    }

    public string Tipo { get;  }

    public override void ExibirDados()
    {
        Console.WriteLine("-");
    }
}
