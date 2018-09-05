using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Metro
    {

        public double valor;

        public Metro(double valor)
        {
            this.valor = valor;
        }

        public static Metro operator +(Metro metro, Centimetro centimetro)
        {
            metro.valor += centimetro.valor / 100;
            return metro;
        }

        public static bool operator ==(Metro metroA, Metro metroB)
        {
            return metroA.valor == metroB.valor;
        }
        public static bool operator !=(Metro metroA, Metro metroB)
        {
            return metroA.valor != metroB.valor;
        }

        public static explicit operator Metro(Centimetro centimetro)
        {
            return new Metro(centimetro.valor / 100);
        }

        public static implicit operator Centimetro(Metro metro)
        {
            return new Centimetro(metro.valor * 100);
        }

    }
}
