

namespace LinqPratice.Filters;

internal class LinqFilter
{
    public static void Filtros(List<Produtos> produtos) 
    {
        var pegandoFiltro = produtos.OrderBy(produtos => produtos.Preco).Select(produtos => produtos.Nome).ToList();

        foreach (var filtro in pegandoFiltro)
        {
            Console.WriteLine($"Produtos {filtro}");
        }
    }

    public static void Media(List<Produtos> produtos) 
    {
        var pegandoFiltro = produtos.Select(produtos => produtos.Preco).Average();
        Console.WriteLine($"Media dos precos dos produtos: {pegandoFiltro}");
       
    }

}
