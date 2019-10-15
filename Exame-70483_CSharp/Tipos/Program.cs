using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    public class Program  
    {
        static void Main(string[] args)
        {

            TiposValor tiposValor = new TiposValor(1, 1, '1', 1.0M, 200, 25, 100, 32, 345, 23465, 1324455, 2);

            Console.WriteLine(tiposValor.Percentual);

            int DiaDaSemana = Convert.ToInt32(DiasDaSemana.Dom);

            Console.WriteLine(DiaDaSemana);


            Console.ReadKey();

            // Tipos C#
            int numero = 100;
            string nome = "Teste AB";
            float valor = 12.5F;
            decimal valorTotal = 360M;
            bool ativo = false;
            byte numeroQuarto = 108;
            sbyte grauCelsius = -2;
            short quantidade = 3690;
            ushort quantidade2 = 6744;
            uint QtdeRegistros = 43905;
            long numerosLongo = -38374;
            long numerosLongo2 = -38374947;
            char sexo = 'F';

            Console.WriteLine("Estes são os tipos do C#");

            Console.WriteLine("Tipo int: {0}", numero);

            Console.WriteLine("Tipo string: {0}", nome);
            Console.ReadLine();

            Console.WriteLine("Tipo decimal: {0}", valorTotal);
            Console.ReadLine();

            Console.WriteLine("Tipo float: {0}", valor);
            Console.ReadLine();

            Console.WriteLine("Tipo bool: {0}", ativo);
            Console.ReadLine();

            Console.WriteLine("Tipo sbyte: {0}", grauCelsius);
            Console.ReadLine();

            Console.WriteLine("Tipo byte: {0}", numeroQuarto);
            Console.ReadLine();

            Console.WriteLine("Tipo short: {0}", quantidade);
            Console.ReadLine();

            Console.WriteLine("Tipo ushort: {0}", quantidade2);
            Console.ReadLine();

            Console.WriteLine("Tipo uint: {0}", QtdeRegistros);
            Console.ReadLine();

            Console.WriteLine("Tipo long: {0}", numerosLongo);
            Console.ReadLine();

            Console.WriteLine("Tipo ulong: {0}", numerosLongo2);
            Console.ReadLine();

            Console.WriteLine("Tipo char: {0}", sexo);
            Console.ReadLine();


            
        }

        

        
    }

   
    


   

}
