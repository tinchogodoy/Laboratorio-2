using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Producto
    {

        private string codigoDeBarras;
        private string marca;
        private float precio;

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static Producto MostrarProducto(Producto producto)
        {
            

            

            return producto;
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarras;
        }

        public static bool operator ==(Producto productoA, Producto productoB)
        { 
             return (productoA.marca == productoB.marca && productoA.codigoDeBarras == productoB.codigoDeBarras);
        }

        public static bool operator !=(Producto productoA, Producto productoB)
        {
            return !(productoA == productoB);
        }

        public static bool operator ==(Producto productoA, string productoString)
        {
            return (productoA.marca == productoString );
        }

        public static bool operator !=(Producto productoA, string productoSrting)
        {
            return !(productoA == productoSrting);
        }



    }
}
