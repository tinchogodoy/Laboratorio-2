using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        public float valor;
        // public double valorPesos = 17,55;// 1 Euro
        //public double valorDolar = 1,3642;// 1 Euro

        public Dolar(float valor)
        {
            this.valor = valor;
        }

        public static bool operator ==(Dolar dolarUno, Dolar dolarDos)
        {
            return dolarUno.valor == dolarDos.valor;
        }
        public static bool operator !=(Dolar dolarUno, Dolar dolarDos)
        {
            return !(dolarUno.valor == dolarDos.valor);
        }
        public static bool operator >(Dolar dolarUno, Dolar dolarDos)
        {
            return dolarUno.valor > dolarDos.valor;
        }
        public static bool operator <(Dolar dolarUno, Dolar dolarDos)
        {
            return !(dolarUno.valor > dolarDos.valor);
        }

        public static double operator +(Dolar dolarUno, Dolar dolarDos)
        {
            return dolarUno.valor += dolarDos.valor;
        }
        public static double operator -(Dolar dolarUno, Dolar dolarDos)
        {
            float resta = dolarUno.valor - dolarDos.valor;
            return resta;
        }

        public static explicit operator Dolar(Pesos pesos)
        {
            return new Dolar(pesos.valor * (float)17.55);
        }

        public static implicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.valor * (float)1.3642);
        }
    }
}
