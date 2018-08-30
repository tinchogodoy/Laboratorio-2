using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_14
{
    public class CalculoDeArea
    {
        static double CalcularCuadrado(double lado)
        {
            double areaCuadrado = 0;

            areaCuadrado = lado * lado;

            return areaCuadrado;

        }

        static double CalcularTriangulo(double alturaA , double baseB)
        {
            double areaTriangulo = 0;

            areaTriangulo = (baseB * alturaA) / 2;

            return areaTriangulo;

        }


        static double CalcularCirculo(double radio)
        {
            double areaCirculo = 0;

            areaCirculo = Math.PI * Math.Pow(radio, 2);

            return areaCirculo;

        }
    }
}
