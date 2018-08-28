using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Automovil.cantidadRuedas = 4;
            Automovil automovil = new Automovil();
            Console.WriteLine(Automovil.cantidadRuedas);
            automovil.velocidadActual = 110;
            Console.WriteLine(automovil.velocidadActual);
            automovil.Acelerar(automovil.velocidadActual);
            Console.WriteLine(automovil.velocidadActual);
            Console.ReadKey();
        }
        
    }
}
