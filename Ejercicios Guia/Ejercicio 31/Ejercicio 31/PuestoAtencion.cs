using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;

        private Puesto puesto;

        public static int NumeroActual {
            get {
                numeroActual += numeroActual;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);//detiene 1 segundo la ejecucion simulando tiempo de atencion.

            return true;
        }

        public PuestoAtencion(Puesto puesto)
        {

        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
