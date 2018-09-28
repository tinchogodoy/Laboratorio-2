using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                StringBuilder ad = new StringBuilder();
                ad.AppendFormat("{0}°{1}", this.anio, this.division);
                return ad.ToString();
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre,apellido,documento)
        {

            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder ed = new StringBuilder();
            ed.AppendFormat("Nombre: {0}, Apellido: {1}, Documento: {2}, Año: {3}, Division: {4}", this.Nombre,this.Apellido,this.Documento,this.anio,this.division);
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
