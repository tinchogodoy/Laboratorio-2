using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";/*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
            valor máximo, el valor mínimo y el promedio.*/
            double valorMaximo = double.MinValue;
            double valorMinimo = double.MaxValue;
            double promedio = 0;
            double auxNumero = 0;
            double acumulador = 0;
            int i = 0;
            List<double> listaNumeros;
            listaNumeros = new List<double>();
            
            for (; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("\ningrese numero: ");
                string aux = Console.ReadLine();
                if (double.TryParse(aux, out auxNumero))
                {
                    listaNumeros.Add(auxNumero);
                    acumulador += auxNumero;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    i--;
                    Console.ReadKey();
                }
            }
            foreach (double num in listaNumeros)
            {
                if (num > valorMaximo)
                {
                    valorMaximo = num;
                }
                if (num < auxNumero)
                {
                    valorMinimo = num;
                }
            }
            promedio = acumulador / (double)i;
            Console.WriteLine("Maximo: {0}", valorMaximo);
            Console.WriteLine("Minimo: {0}", valorMinimo);
            Console.WriteLine("Promedio: {0}", promedio);

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("lista: {0} ", listaNumeros[i]);
            }
            Console.ReadKey();
        }
    }
    
}
