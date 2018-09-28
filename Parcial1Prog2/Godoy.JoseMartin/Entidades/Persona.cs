using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                this.ValidarDocumentacion(this.documento);//este va a llamar a los metodos segun corresponda en Alumno o Profesor
                this.documento = value;
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder e = new StringBuilder();
            e.AppendFormat("Nombre: {0}, Apellido: {1}, Division: {2}.",Nombre, Apellido, Documento);
            return e.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }



        protected abstract bool ValidarDocumentacion(string doc);
    }
}
