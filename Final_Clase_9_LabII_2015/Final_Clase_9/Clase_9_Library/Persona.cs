using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

      public abstract string PosicionSocietaria();

    //Crear un método Mostrar(Persona p) en Persona.Este deberá ser declarado como virtual, protegido y de clase,
    //retornando un string con los datos de la persona.Reutilizar este código en el método Mostrar() de la clase Empleado.

      protected virtual string Mostrar(Persona p)
      {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Nombre  : " + this._nombre);
        sb.AppendLine("Apellido: " + this._apellido);
        return sb.ToString();
      }

    }
}
