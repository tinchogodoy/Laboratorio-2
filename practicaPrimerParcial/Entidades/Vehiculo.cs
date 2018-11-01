using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                    this.patente = value;
                else
                    this.patente = "";
            }
        }
        /// <summary>
        /// Establece la patente del vehiculo y la fecha de ingreso como
        /// 3 horas anterior a la fecha actual
        /// </summary>
        /// <param name="patente"></param>
        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        #region Métodos

        public abstract string ConsultarDatos();
        /// <summary>
        /// Devuelve información del Vehiculo y hora de ingreso
        /// </summary>
        /// <returns></returns>
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendFormat("Hora de ingreso: {0}\n", this.ingreso.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// Devuelve la patente del vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Patente {0}", this.Patente);
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Dos vehiculos son iguales si coinciden sus patentes y son del mismo tipo de vehiculo
        /// </summary>
        /// <param name="vehiculoUno"></param>
        /// <param name="vehiculoDos"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return ((vehiculoUno.Patente == vehiculoDos.Patente) && vehiculoUno.Equals(vehiculoDos));
        }

        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            return !(vehiculoUno == vehiculoDos);
        }

        #endregion

    }
}
