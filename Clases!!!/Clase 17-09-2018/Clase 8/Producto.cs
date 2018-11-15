using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8
{
    public class Producto
    {
        int identificador { get; set; }

        public string nombre{

            get
            {

            }
            set
            {

            }
        }

        private double precio();

        private double iva();
        
        public double getTotal()
        {
            this.iva = this.precio * 1.21;
            return this.precio * 1.21;
        } 


    }
}
