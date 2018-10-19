using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
         }

        private float CalcularCosto()
        {
            float precio = 0;
            precio = this.costo * this.duracion;
            return precio;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)//el constructor base de otra clase
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public new string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();// StringBuilder
            sb.AppendFormat("Duracion: {0} , Nuero Origen: {1} , numero destino {2}",this.Duracion, this.NroOrigen, this.NroDestino);
            
            return sb.ToString();
        }


    }
}
