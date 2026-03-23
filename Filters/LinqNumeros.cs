using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPratice.Filters;

internal class LinqNumeros
{

    public static void FiltroInteiros(List<int> numeros)
    {
        var filtroDaListaPares = numeros.Where(numeros => numeros > 4).ToList()!;

        foreach (var numero in filtroDaListaPares)
        {
            Console.WriteLine("Exibindo todos, os números pares...");
            Console.WriteLine(numero);
        }
    }

}
