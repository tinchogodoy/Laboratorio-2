using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";/*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
            valor máximo, el valor mínimo y el promedio.*/
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;
            Double promedio = 0;
            int auxNumero = 0;
            int acumulador = 0;
            int i = 0;
            
            for (; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("\ningrese numero: ");
                if (int.TryParse(Console.ReadLine(), out auxNumero))
                {
                    Console.ReadKey();
                    if (valorMaximo < auxNumero)
                    {
                        valorMaximo = auxNumero;
                    }
                    if (valorMinimo > auxNumero)
                    {
                        valorMinimo = auxNumero;
                    }
                    acumulador += auxNumero;

                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    i--;
                    Console.ReadKey();                    
                }

            }
            promedio =(double) acumulador / i;
            Console.WriteLine("Maximo: {0}", valorMaximo);
            Console.WriteLine("Minimo: {0}", valorMinimo);
            Console.WriteLine("Promedio: {0}", promedio);
            Console.ReadKey();
        }



    }
}
