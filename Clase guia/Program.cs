using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            string auxNumero = "";
            int numero = 0;
            int maximo = int.MaxValue;
            int minimo = int.MinValue;
            float acumulador = 0;
            float promedio=0;
            int i;
            int flag = 0;
            bool esNumero = false;
                                 
            for (i=0;i<5;i++)
            {
                Console.WriteLine("\ningrese el numero: ");
                auxNumero = Console.ReadLine();
                if (esNumero = int.TryParse(auxNumero, out numero))
                {
                    acumulador = acumulador + numero;
                    if(flag==0)
                    {
                        maximo = numero;
                        minimo = numero;
                        flag = 1;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
                else
                {
                    Console.WriteLine("ingrese solo numeros...");
                    i--;
                }
            }
            promedio = acumulador / i;
            Console.WriteLine("Máximo: "+maximo);
            Console.WriteLine("Mínimo: "+minimo);
            Console.WriteLine("Promedio: "+promedio);
            Console.ReadKey();
        }
    }
}
