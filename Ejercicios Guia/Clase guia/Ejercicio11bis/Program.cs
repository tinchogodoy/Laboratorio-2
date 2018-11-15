using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11bis
{
        class Program
        {
            static void Main(string[] args)
            {
                string buferValor = "";
                int valor = 0;
                int max = int.MinValue;
                int min = int.MaxValue;
                float promedio = 0;
                bool esNumero = false;
                int acumulador = 0;
                int flag = 0;
                int i;
                for ( i = 0; i < 10; i++)
                {
                    Console.WriteLine("\ningrese el numero: ");
                    buferValor = Console.ReadLine();
                    if (esNumero = int.TryParse(buferValor, out valor))
                    {
                        if (Ejercicio11.Validacion.Validar(valor, min, max))
                        {
                            acumulador = acumulador + valor;
                            if (flag == 0)
                            {
                                max = valor;
                                min = valor;
                                flag = 1;
                            }
                            if (valor < min)
                            {
                                min = valor;
                            }
                            else if (valor > max)
                            {
                                max = valor;
                            }
                        }
                        else
                        {

                            Console.WriteLine("ingrese mayor igual a -100 y menor igual a 100...");
                            i--;
                        }
                    }

                }
                promedio = acumulador / i;
                Console.WriteLine("Máximo: " + max);
                Console.WriteLine("Mínimo: " + min);
                Console.WriteLine("Promedio: " + promedio);
                Console.ReadKey();
                
            }
        }
    
}
