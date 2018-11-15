using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";//Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
            string auxNumero = "";
            int numero = 0;
            double cuadrado = 0;
            double cubo = 0;
            bool esNumero = false;
            Console.WriteLine("\ningrese numero: ");
            auxNumero = Console.ReadLine();
            if (esNumero = int.TryParse(auxNumero, out numero))
            {
                if (numero > 0)
                {
                    cuadrado = Math.Pow(numero, 2);//numero ^ 2
                    cubo = Math.Pow(numero, 3);
                    Console.WriteLine("Elevado al cuadrado" + cuadrado);
                    Console.WriteLine("Elevado al cubo" + cubo);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            }
            Console.ReadKey();
        }
    }
}
