using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_13
{
     public class Conversor
    {
        public static string DecimalBinario(double numeroDecimal) //Convierte un número de decimal a binario.
        {
            string numeroBinario = "";

            numeroDecimal = 2;



            return numeroBinario;
        }
        public static double BinarioDecimal(string numeroBinario) //Convierte un número binario a decimal.
        {
            double numeroDecimal = 0;

            double.TryParse(numeroBinario, out numeroDecimal);


            return numeroDecimal;
        }
    }
}
