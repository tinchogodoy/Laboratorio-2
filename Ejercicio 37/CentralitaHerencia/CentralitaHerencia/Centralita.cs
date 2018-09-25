using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> ListaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                float ganancia = 0;
                    
                return ganancia;
            }

        }
        public float GananciasPorProvincia
        {
            get
            {
                float ganancia = Llamada.TipoLlamada();
                return ganancia;
            }
        }
        private float CalcularGanancia()
        {

        }

         
    }
}
