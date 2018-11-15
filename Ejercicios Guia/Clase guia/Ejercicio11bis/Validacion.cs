using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio11
{

        // 11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
        //Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
        //posea la siguiente firma: bool Validar(int valor, int min, int max):
        //a.valor: dato a validar
        //b.min y max: rango en el cual deberá estar la variable valor.
        //Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
        //Nota: Utilizar variables escalares, NO utilizar vectores.
    public class Validacion
    {

        // Método estáticos valida entre -100 y 100.
        public static bool Validar(int valor, int min, int max)
        {
           
            if (valor >= -100 && valor <= 100 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
