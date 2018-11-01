using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        #region Constructores

        /// <summary>
        /// El valor por hora para las motos será de 30
        /// </summary>
        static Moto()
        {
            Moto.valorHora = 30;
        }
        /// <summary>
        /// Crea una nueva instancia de Moto con patente y cilindrada dadas
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        public Moto(string patente, int cilindrada): base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }
        /// <summary>
        /// Crea una nueva instancia de Moto con patente, cilindrada y ruedas dadas
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        /// <param name="ruedas"></param>
        public Moto(string patente, int cilindrada, short ruedas): this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }
        /// <summary>
        /// Crea una nueva instancia de Moto con patente, cilindrada y ruedas dadas. Establece un nuevo valor
        /// por hora para las Motos
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="cilindrada"></param>
        /// <param name="ruedas"></param>
        /// <param name="valorHora"></param>
        public Moto(string patente, int cilindrada, short ruedas, int valorHora): this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Devuelve los datos de la Moto
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Cilindrada: {0}\n", this.cilindrada);
            sb.AppendFormat("Ruedas: {0}\n", this.ruedas);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        /// <summary>
        /// Devuelve datos de la moto con su precio de estadia correspondiente
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            int dias;
            StringBuilder sb = new StringBuilder();

            dias = (DateTime.Now - this.ingreso).Hours;
            sb.Append(base.ImprimirTicket());

            sb.AppendFormat("Costo estadia: {0}\n", dias * Moto.valorHora);

            return sb.ToString();
        }

        #endregion

    }
}
