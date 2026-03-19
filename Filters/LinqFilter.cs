

namespace LinqPratice.Filters;

internal class LinqFilter
{
    public static void Filtros(List<Produtos> produtos) 
    {
        var pegandoFiltro = produtos.Select(produtos => produtos.Nome).ToList();

        foreach (var filtro in pegandoFiltro)
        {
            Console.WriteLine($"Produtos {filtro}");
        }
    }

}
