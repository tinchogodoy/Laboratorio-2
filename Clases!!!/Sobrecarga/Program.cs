using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine((new Metro (5) + new Centimetro (800)).valor);

            Metro metro = new Metro(5);
            Centimetro centimetro = new Centimetro(800);
            Metro resultado = metro + (Metro)centimetro;
            Console.WriteLine(resultado.valor);


           // Sobrecarga sobrecarga = new Sobrecarga();


            
           // Console.WriteLine(Sobrecarga.Sumar((int)5, (int)8)); 
           

            Console.ReadKey();
                
        }
    }
}
