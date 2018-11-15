using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        private PuestoAtencion caja;

        private Queue<Cliente> clientes;

        private string nombre;

        Cliente Cliente { get; set; }

        private Negocio()
        {
            clientes = new Queue<Cliente>();//Es una cola de clientes
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1); //Crea la caja a asignar 
        }

        public Negocio(string nombre)
        {

        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if(c == cliente)
                {
                    return true;
                }

            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes += 1;

            }
        }


           

    }
}
