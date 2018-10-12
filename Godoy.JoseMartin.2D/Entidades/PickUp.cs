using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente,modelo)
        {
 
        }

        public override string ConsultarDatos()
        {
            return this.ToString();
        }

        
    }
}
