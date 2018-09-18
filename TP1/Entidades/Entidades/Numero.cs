using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        private double ValidarNumero(string strNumero)
        {
            double validado = Convert.ToDouble(strNumero);
            return validado;
        }

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        private Numero(double numero)
        {
            this.numero = numero;
        }

        private Numero(string numero)
        {
            this.SetNumero = numero;
        }

        public string BinarioDecimal(string binario)
        {
            double numero = 0;
            for(int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '0' || binario[i] == '1')
                {
                    if(binario[i] == '1')
                        numero += Math.Pow(2, i);
                }
                else
                {
                    return string.Format("Valor Invalido");
                }
            }
            return numero.ToString();
        }

        public string DecimalBinario(string numeroStr)
        {
            double numero = Convert.ToDouble(numeroStr);
            return DecimalBinario(numero);
        }

        public string DecimalBinario(double numero)
        {
            string binario = "";
            while (numero > 0)
            {
                if (numero % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                numero = (int)numero / 2;
            }
            return binario;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            if (!(n1 is null) && !(n2 is null))
            {
                return n1.numero - n2.numero;
            }

            return 0;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            if (!(n1 is null) && !(n2 is null))
            {
                return n1.numero + n2.numero;
            }

            return 0;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (!(n1 is null) && !(n2 is null))
            {
                return n1.numero / n2.numero;
            }

            return 0;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            if (!(n1 is null) && !(n2 is null))
            {
                return n1.numero * n2.numero;
            }

            return 0;
        }
        
    }

}
