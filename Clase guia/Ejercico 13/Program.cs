using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_13
{
   // 13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase(estáticos):
   //string DecimalBinario(double). Convierte un número de decimal a binario.
   //double BinarioDecimal(string). Convierte un número binario a decimal.
    class Program
    {
        static void Main(string[] args)
        {
            string numeroBinario = "";
            double numeroDecimal = 0;
            bool esNumero = false;
            string bufferDecimal = "";
            double bufferBinario = 0;
            Console.WriteLine("Ingrese un numero decimal: ");
            bufferDecimal = Console.ReadLine();

            if (esNumero = double.TryParse(bufferDecimal, out numeroDecimal))
            {
                numeroBinario = Ejercico_13.Conversor.DecimalBinario(numeroDecimal);


            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
            
        }
    }
}
