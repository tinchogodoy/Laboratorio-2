using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo()
        {
            equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> torneo, T e1)
        {
            foreach( Equipo e in torneo.equipos )
            {
                if (e == e1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T e1)
        {

            return !(torneo == e1);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T e)
        {
            if (torneo == e)
            {
                torneo.equipos.Add(e);
            }
            return torneo;
        }

        public static string Mostrar(Torneo<T> torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Torneo {0}\n",torneo.nombre);
            foreach(T e in torneo.equipos)
            {
                sb.AppendFormat("Equipo: {0}\n", e.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T e1,T e2)
        {
            Random ran = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} - {2} {3}\n", e1 , ran.Next(0, 144), ran.Next(0, 144), e2);
            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                Random ran = new Random();
                int e1, e2;
                e1 = ran.Next(0, this.equipos.Count);
                do
                {
                    e2 = ran.Next(0, this.equipos.Count);
                } while (e1!=e2);
                return this.CalcularPartido(this.equipos[e1], this.equipos[e2]);
            }
        }
    }
}
/*
6. El método privado CalcularPartido<T, T>: string recibirá dos elementos del
tipo T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando
Random un resultado del partido. Retornará el resultado con el siguiente
formato: “[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”, siendo
EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.
7. La propiedad pública JugarPartido tomará dos equipos de la lista al azar y
calculará el resultado del partido a través del método CalcularPartido.*/