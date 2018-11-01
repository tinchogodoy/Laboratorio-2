using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        #region Constructores

        /// <summary>
        /// Se instancia la lista de vehiculos para el estacionamiento
        /// </summary>
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Crea una nueva instancia de estacionamiento con nombre y espacio disponible dados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="espacioDisponible"></param>
        public Estacionamiento(string nombre, int espacioDisponible): this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Devuelve información del estacionamiento y de todos sus vehículos
        /// </summary>
        /// <param name="estacionamiento"></param>
        public static explicit operator string(Estacionamiento estacionamiento)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Estacionamiento {0}\n", estacionamiento.nombre);
            sb.AppendFormat("Espacion disponible {0}\n", estacionamiento.espacioDisponible);
            foreach(Vehiculo vehiculo in estacionamiento.vehiculos)
            {
                sb.AppendLine(vehiculo.ConsultarDatos());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Un estacionamiento es igual al vehiculo, si este se encuentra en el estacionamiento
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo vehiculoEstacionamiento in estacionamiento.vehiculos)
            {
                if(vehiculo == vehiculoEstacionamiento)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        /// <summary>
        /// Se agregará el vehiculo al estacionamiento si:
        /// Hay espacio disponible
        /// El vehiculo tiene patente asignada
        /// No se encuentre previamente en el estacionamiento
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible
                && vehiculo.Patente.Length != 0
                && estacionamiento != vehiculo)
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }
            return estacionamiento;
        }
        /// <summary>
        /// Al eliminar un vehiculo del estacionamiento, se devuelve el ticket con datos y
        /// precio de estadia
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                return vehiculo.ImprimirTicket();
            }

            return "El vehículo no es parte del estacionamiento\n";
        }

        #endregion
    }
}
