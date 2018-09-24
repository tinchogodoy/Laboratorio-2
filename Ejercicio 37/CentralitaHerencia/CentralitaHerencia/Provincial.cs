using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia 
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3  
        }

        protected Franja franjaHoraria;

        private float CalcularCosto()
        {
            float precio = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    float franja1 = 0,99;
                    precio = franja1 * this.Duracion;
                    break;
                case 1:



            }
            precio = this.duracion * Franja;

            return precio;
        }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja,new Llamada(duracion,destino,origen))
        {

        }

    }

}
