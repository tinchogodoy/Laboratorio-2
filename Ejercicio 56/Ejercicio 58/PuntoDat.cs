using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58
{
    public class PuntoDat : Archivo , IArchivos<PuntoDat>
    {
        string contenido;

        public string Contenido
        {
            get
            {
                return "";
            }

            set
            {
                Contenido = contenido;
            }
        }

        public bool Guardar(PuntoDat ruta)
        {
            return true;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat pd = new PuntoDat();

            return pd;
        }

    }
}
