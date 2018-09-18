using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        public object Operador { get; private set; }

        public double Operar(Numero numUno, Numero numDos, string operador)
        {
            double retorno = 0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    retorno = numUno + numDos;
                    break;
                case "-":
                    retorno = numUno - numDos;
                    break;
                case "*":
                    retorno = numUno * numDos;
                    break;
                case "/":
                    retorno = numUno / numDos;
                    break;
            }
            return retorno;
        }
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if ( operador == "-" || operador == "/" || operador == "*" || operador == "+")
            {
                retorno = operador;
            }
            return operador;
        }
    }
}
