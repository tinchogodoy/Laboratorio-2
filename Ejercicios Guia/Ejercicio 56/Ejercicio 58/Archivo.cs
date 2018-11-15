using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_58
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
                throw new FileNotFoundException("no existe el archivo!");
            return true;
        }
    }
}
