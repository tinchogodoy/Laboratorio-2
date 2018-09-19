using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        public static double Operar(Numero numUno, Numero numDos, string operador)
        {
            
        }

        private string ValidarOperador(string operador)
        {
            if ( operador == - || operador == / || operador == *)
            {

            }
            else
            {
                operador = "+";
                return operador;
            }
        }

    }
}
