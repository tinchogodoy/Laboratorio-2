using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                int dias = (DateTime.Now - fechaIngreso).Days;
                return dias;//devolver desde la fecha de ingreso hasta la actualidad
            }
        }

        public Profesor(string nombre, string apellido, string documento) : this(nombre, apellido, documento,DateTime.Now)
        { 

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder ed = new StringBuilder();
            ed.AppendFormat("Nombre: {0}, Apellido: {1}, Documento: {2}, Ingreso: {3}", this.Nombre, this.Apellido, this.Documento,this.fechaIngreso);
            return ed.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            // Creo el patrón indicando que tendrá 2 dígito (d{2}) luego guión, luego 4 dígitos, luego guión
            string patron = "^\\d{2}-\\d{4}-$";
            if (Regex.IsMatch(doc, patron))
            {
                return true;
            }
            return false;
        }


    }
}
