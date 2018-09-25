﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
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

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int orden = 0;//ordenar de forma ascendente.
            return orden;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} minutos, {1} Origen, {2} Destino", this.Duracion, this.NroOrigen, this.NroDestino);
            // usar StringBuilder.

            return sb.ToString();
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
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
