using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int orden = 0;//ordenar de forma ascendente.
            if (llamada1.Duracion > llamada2.Duracion)
            {
                orden = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                orden = -1;
            }
            return orden;
        }

        public string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion: {0} minutos, Origen: {1}, Destino: {2}", this.Duracion, this.NroOrigen, this.NroDestino);
            // usar StringBuilder.

            return sb.ToString();
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
            
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
                
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }


        }


    }
}
