

namespace LinqPratice.Filters;

internal class LinqFilter
{
    public static void Filtros(List<Produtos> produtos) 
    {
        var pegandoFiltro = produtos.Where(produtos => produtos.Preco>1000).Select(produtos => produtos.Nome).ToList();

        foreach (var filtro in pegandoFiltro)
        {
            Console.WriteLine($"Produtos {filtro}");
        }
    }

}
