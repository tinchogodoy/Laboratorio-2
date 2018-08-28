using System;

namespace Ejercicio_11
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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\ningrese el numero: ");
                buferValor = Console.ReadLine();
                if (esNumero = int.TryParse(buferValor, out valor))
                {
                   if(Ejercicio11.Validacion.Validar(valor, min, max)
                   {
                        acumulador = acumulador + numero;
                        if (flag == 0)
                        {
                            max = valor;
                            min = valor;
                            flag = 1;
                        }
                        if ( valor < min)
                        {
                            min = valor;
                        }
                        else if (valor>max)
                        {
                            max = valor;
                        }
                    }
                    else
                    {

                        Console.WriteLine("ingrese solo numeros...");
                        i--;
                    }
                }
                    
            }
                promedio = acumulador / i;
                Console.WriteLine("Máximo: " + max);
                Console.WriteLine("Mínimo: " + min;
                Console.WriteLine("Promedio: " + promedio);
                Console.ReadKey();
                Console.ReadKey();
        }
    }
}
