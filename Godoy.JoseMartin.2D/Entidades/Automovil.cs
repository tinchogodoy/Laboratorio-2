using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        private Automovil() 
        {
            this.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) :base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color) 
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return this.ToString();
        }



    }
}
