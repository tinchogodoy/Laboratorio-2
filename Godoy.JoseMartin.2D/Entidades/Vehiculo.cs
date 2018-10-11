using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {

        protected DateTime ingreso;
        private string patente;

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.patente = patente;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                //if(validarPatente) valida 6 caracteres
                this.Patente = patente;
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return "";

        }

        public virtual string ImprimirTiket()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat(" {0}",);
            return sb.ToString();
        }

        public static  bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(v1.Patente == v2.Patente /* && misma clase*/)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            if (!(v1 == v2))
            {
                return true;
            }
            return false;
        }

    }
}
