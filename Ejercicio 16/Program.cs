using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Pepe";
            alumno1.apellido = "Argento";
            alumno1.legajo = 1;

            alumno2.nombre = "Pepito";
            alumno2.apellido = "Gomez";
            alumno2.legajo = 2;

            alumno3.nombre = "Jorgito";
            alumno3.apellido = "Caseres";
            alumno3.legajo = 3;

            alumno1.Estudiar(2, 8);
            alumno2.Estudiar(4, 4);
            alumno3.Estudiar(8, 8);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();


            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();







        }
    }
}
