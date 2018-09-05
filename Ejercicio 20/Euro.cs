using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        public float valor;
       // public double valorPesos = 17,55;// 1 Euro
        //public double valorDolar = 1,3642;// 1 Euro

        public Euro(float valor)
        {
            this.valor = valor;
        }

        public static bool operator ==( Euro euroUno, Euro euroDos )
        {
            return dolarUno.valor == dolarDos.valor;
        }
        public static bool operator !=(Euro euroUno, Euro euroDos)
        {
            return !(dolarUno.valor == dolarDos.valor);
        }
        public static bool operator >(Euro euroUno, Euro euroDos)
        {
            return euroUno.valor > euroDos.valor;
        }
        public static bool operator <(Euro euroUno, Euro euroDos)
        {
            return !(euroUno.valor > euroDos.valor);
        }

        public static double operator +(Euro euroUno, Euro euroDos)
        {
            return euroUno.valor += euroDos.valor;
        }
        public static double operator -(Euro euroUno, Euro euroDos)
        {
            float resta = euroUno.valor - euroDos.valor;
            return resta;
        }

        public static explicit operator Euro(Pesos pesos)
        {
            return new Euro(pesos.valor / (float)17.55);
        }

        public static implicit operator Euro(Euro dolar)
        {
            return new Euro(dolar.valor / (float)1.3642);
        }

        /* Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí
         con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro
         equivale a 1,3642 dólares y 1 dólar equivale a 17,55 pesos.*/
    }
}
