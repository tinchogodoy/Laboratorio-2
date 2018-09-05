using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            Random randomFinal = new Random();
            if (nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = randomFinal.Next(0, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string Mostrar()
        {
            if(this.notaFinal == -1)
            {
                return String.Format("Alumno: {0}, Apellido {1}, notaFinal DESAPROBADO ", this.nombre, this.apellido);
            }
            else
            {
                
                return String.Format("Alumno: {0}, Apellido {1}, notaFinal {2} ", this.nombre, this.apellido, this.notaFinal);
            }
           
        }
    }

}
