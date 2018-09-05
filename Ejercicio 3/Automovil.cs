using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    
    
        public class Automovil
        {
            // Atributos NO estáticos
            public Single velocidadActual;
            // Atributos estáticos
            public static Byte cantidadRuedas;
            // Métodos estáticos
            public static void MostrarCantidadRuedas()
            {
                Console.Write(Automovil.cantidadRuedas);
            }
            // Métodos NO estáticos
            public void Acelerar(Single velocidad)
            {
                this.velocidadActual += velocidad;
            }
        }
    
}
