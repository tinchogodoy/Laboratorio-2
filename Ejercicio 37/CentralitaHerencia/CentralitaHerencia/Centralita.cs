using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                float ganancia = 0;
                    
                return ganancia;
            }

        }
        public float GananciasPorProvincial
        {
            get
            {
                float ganancia = 0;
                return ganancia;
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                float ganancia = 0;
                return ganancia;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                List<Llamada> llamadas = new List<Llamada>();
                listaDeLlamadas = llamadas;
                             
                return listaDeLlamadas;
            }
        }

        private float CalcularGanancia()
        {
            float ganancia = 0;
            switch (Llamada.TipoLlamada.Local)
            {

                case Llamada.TipoLlamada.Local:

                break;
                case Llamada.TipoLlamada.Provincial:

                break;
                case Llamada.TipoLlamada.Todas:

                break;
                    
            }

            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();// StringBuilder
            sb.AppendFormat("Razon Social: {0} , Ganancia total: {1} , Ganancia llamadas locales {2}, Ganancia por llamadas provinciales {3}, ", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal , this.GananciasPorProvincial);
            sb.AppendFormat("detalles de llamadas: ");
            
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {

        }
         
    }
}
