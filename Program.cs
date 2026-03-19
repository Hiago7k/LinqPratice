
using LinqPratice;
using LinqPratice.Filters;


List<Produtos> produtos = new List<Produtos>
{
    new  ProdutoFisico("Celular", 2300, "Fisico"),
    new ProdutoDigital("Pacote office", 500, "Digital")
};


LinqFilter.Filtros(produtos);