using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil: Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        #region Constructores

        /// <summary>
        /// El valor por hora de Automovil será 50
        /// </summary>
        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        /// <summary>
        /// Crea una nueva instancia de Automovil con patente y color dados
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Automovil(string patente, ConsoleColor color): base(patente)
        {
            this.color = color;
        }
        /// <summary>
        /// Crea una nueva instancia de Automovil con patente y color dados. Establece un nuevo valor
        /// por hora para los Automoviles
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        /// <param name="valorHora"></param>
        public Automovil(string patente, ConsoleColor color, int valorHora): this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Devuelve los datos del Automovil
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Color {0}\n", color.ToString());

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        /// <summary>
        /// Devuelve información del Automovil y el precio de estadia correspondiente
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            int dias;
            StringBuilder sb = new StringBuilder();

            dias = (DateTime.Now - this.ingreso).Hours;
            sb.Append(base.ImprimirTicket());

            sb.AppendFormat("Costo estadia: {0}\n", dias * Automovil.valorHora);

            return sb.ToString();
        }

        #endregion

    }
}
