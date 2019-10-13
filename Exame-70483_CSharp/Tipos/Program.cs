using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            TiposValor tiposValor = new TiposValor(1, 1, '1', 1.0M, 200, 25, 100, 32, 345, 23465, 1324455, 2);

            Console.WriteLine(tiposValor.Percentual);

            int DiaDaSemana = Convert.ToInt32(DiasDaSemana.Dom);

            Console.WriteLine(DiaDaSemana);


            Console.ReadKey();

        }
    }
}
