using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp: Vehiculo
    {
        private string modelo;
        private static int valorHora;

        #region Constructores

        /// <summary>
        /// El valor por hora para las PickUp será de 70
        /// </summary>
        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        /// <summary>
        /// Crea una nueva instancia de PickUp con patente y modelo dado
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="modelo"></param>
        public PickUp(string patente, string modelo): base(patente)
        {
            this.modelo = modelo;
        }
        /// <summary>
        /// Crea una nueva instancia de PickUp con patente y modelo dado. Establece un nuevo valor por hora
        /// para las PickUp
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="modelo"></param>
        /// <param name="valorHora"></param>
        public PickUp(string patente, string modelo, int valorHora): this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Devuelve la información de la PickUp
        /// </summary>
        /// <returns></returns>
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Modelo: {0}\n", this.modelo);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        /// <summary>
        /// Devuelve la información de la PickUp con el valor de la estadia correspondiente
        /// </summary>
        /// <returns></returns>
        public override string ImprimirTicket()
        {
            int dias;
            StringBuilder sb = new StringBuilder();

            dias = (DateTime.Now - this.ingreso).Hours;
            sb.Append(base.ImprimirTicket());

            sb.AppendFormat("Costo estadia: {0}\n", dias * PickUp.valorHora);

            return sb.ToString();
        }

        #endregion

    }
}
