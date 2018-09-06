using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Estante
    {

        private Producto[] producto;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.producto = new Producto[capacidad];
        }
       
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        
        public Producto[] GetProductos()
        {
            return this.producto;
        }

        public string MostrarEstante(Estante estanteA)
        {
            string bufferEstante;
            bufferEstante = string.Format(" Ubicacion: {0} ", estanteA.ubicacionEstante);

            for (int i=0; i<estanteA.producto.Length; i++)
            {
                if(ReferenceEquals( estanteA.producto[i], null))
                {
                    bufferEstante = string.Concat(bufferEstante, Producto.MostrarProducto(estanteA.producto[i]));
                }
            }
            return bufferEstante;
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            return (estante == producto);
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public bool operator +(Estante estante, Producto producto)
        {

            for (int i=0; i<estante.producto.Length; i++)
            {

                
            }
        }

        public Estante operator(Estante estante, Producto producto)
        {


            return estante.producto;
        } 


    }
}
