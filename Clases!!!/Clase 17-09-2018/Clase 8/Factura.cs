using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8
{
    public class Factura
    {
        int numero;
        int tipo;
        DateTime fecha;
        int moneda;

        public ListProductos productos; 

        public Factura()
        {
            this.productos = new List<Producto>
        }


        public double GetTotal()
        {

        }

    }
}
