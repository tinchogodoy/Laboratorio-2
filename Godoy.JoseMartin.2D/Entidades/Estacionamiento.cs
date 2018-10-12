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

         Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        public static explicit operator string(Estacionamiento e)
        {
            return e.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo v in estacionamiento.vehiculos)
            {
                if(v == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo v in estacionamiento.vehiculos)
            {
                return (!(v == vehiculo));
            }
            return true;
        }
        
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach(Vehiculo v in estacionamiento.vehiculos)
            {
                if(v == vehiculo )
                {
                    return estacionamiento;
                }
            }
            estacionamiento.vehiculos.Add(vehiculo);
            return estacionamiento;
        }

        public static Estacionamiento operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in estacionamiento.vehiculos)
            {
                if (!(v == vehiculo && v.Patente == vehiculo.Patente))
                {
                    estacionamiento.vehiculos.Remove(vehiculo);
                    return estacionamiento;
                }

            }
            
            return estacionamiento;

        }





    }
}
