

namespace LinqPratice
{
    internal class ProdutoDigital : Produtos 
    {
        public ProdutoDigital(string nome, decimal preco, string digital) : base(nome, preco)
        {
            Digital = digital;
        }

        public string Digital { get;  }
    }
}
