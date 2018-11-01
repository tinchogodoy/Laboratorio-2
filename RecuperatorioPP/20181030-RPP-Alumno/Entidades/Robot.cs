using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Robot
    {
        private static int capacidadEnergia;

        public int CapacidadEnergia
        {
            get { return capacidadEnergia; }
        }
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
        }
        private int energia;

        protected int Energia
        {
            get { return energia; }
        }

        private static int contador;
        protected string origen;

        public virtual bool CargarEnergia(int energia)
        {
            if(energia > 0 && energia < this.CapacidadEnergia)
            {
             return true;
            }
            else
            {
                return false;
            }
           
        }

         static Robot()
        {
            capacidadEnergia = 50;
            contador = 0;
        }

        protected Robot()
        {
            this.origen = "Coreano";
            this.energia = 10;
            this.codigo = contador++;
        }

        public Robot(int energia, string origen) : this()
        {

        }

        public abstract string ServirHumanidad();

        public virtual string ToString()
        {
            return String.Format("Arenae {0}", this.origen);//
        }

        public static bool operator ==(Robot robotUno, Robot robotDos)
        {
            return (robotUno.codigo == robotDos.codigo);
        }

        public static bool operator !=(Robot robotUno, Robot robotDos)
        {
            return !(robotUno == robotDos);
        }
        
    }
}
