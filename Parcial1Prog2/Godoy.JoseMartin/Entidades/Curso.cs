using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                StringBuilder ad = new StringBuilder();
                ad.AppendFormat("{0}°{1}", this.anio, this.division);
                return ad.ToString();
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string (Curso c)// te permite castear a string a curso, siempre public static
        {
            StringBuilder ad = new StringBuilder();
            ad.AppendFormat("Año: {0}, Division: {1}, Profesor: {2}", c.anio,c.division, c.profesor );

            foreach(Alumno alumno in c.alumnos)
            {
                ad.AppendLine(alumno.ExponerDatos());
            }
            return ad.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {          
            if(c.AnioDivision == a.AnioDivision)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Curso c, Alumno a)//todos los operator son siempre statico
        {
            return !(c==a);
        }

        public static Curso operator +(Curso c, Alumno a)//El operador + entre Curso y Alumno agregará al alumno al curso siempre y cuando su Año y División coincidan. 
        {
            if (c.AnioDivision == a.AnioDivision)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

    }
}
