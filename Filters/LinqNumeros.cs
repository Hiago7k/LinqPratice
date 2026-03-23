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
        var filtroDaListaPares = numeros.Where(numeros => numeros > 0).ToList()!;

        foreach (var numero in filtroDaListaPares)
        {
            if (numero % 2 == 0)
            {
                Console.Write("Exibindo numeros pares  ");
                Console.WriteLine(numero);
            }   
        }
    }

}
