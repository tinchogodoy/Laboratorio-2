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

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {                
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }

        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            
            foreach(Llamada llamada in this.listaDeLlamadas)
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    if(llamada is Local)
                    {
                        ganancia += ((Local)llamada).CostoLlamada;
               
                    }
                break;
                case Llamada.TipoLlamada.Provincial:
                    if (llamada is Provincial)
                    {
                        ganancia += ((Provincial)llamada).CostoLlamada;
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    if (llamada is Local)
                    {
                        ganancia += ((Local)llamada).CostoLlamada;

                    }else if (llamada is Provincial)
                    {
                        ganancia += ((Provincial)llamada).CostoLlamada;
                    }
                    break;
            }
            
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();// StringBuilder
            sb.AppendFormat("Razon Social: {0}\n Ganancia total: {1}\n Ganancia llamadas locales: {2}, Ganancia por llamadas provinciales: {3}\n ", 
                this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal , this.GananciasPorProvincial);
            sb.AppendFormat("detalles de llamadas: ");
            
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.Append("\n");
                sb.Append(llamada.Mostrar());
            }
            sb.Append("\n");

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
         
    }
}
