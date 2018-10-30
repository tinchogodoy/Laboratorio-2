using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre.Equals(e2.nombre))
            {
                if (e1.fechaCreacion.Equals(e2.fechaCreacion))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", this.nombre, this.fechaCreacion);
            return sb.ToString();
        }
    }
}
/*Generar la clase Equipo abstracta.
1. Agregar un atributo nombre : string y otro fechaCreacion : datetime.
2. Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
3. El método Ficha retornará el nombre del equipo y su fecha de creación con el
siguiente formato “[EQUIPO] fundado el[FECHA]”.*/