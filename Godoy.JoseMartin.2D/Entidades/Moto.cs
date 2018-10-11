using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private int valorHora;

        private Moto() 
        {
            this.valorHora = 30;
        }

        public Moto(string patente, int cilindrada, short ruedas) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }

        public Moto(string patente,int cilindrada,short ruedas,int valorHora) : this()
        {
          
        }

        public override string ConsultarDatos()
        {
            return this.ToString();
        }



    }
}
