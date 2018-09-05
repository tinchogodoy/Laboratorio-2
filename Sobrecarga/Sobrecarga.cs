using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{

    
/*
    public Sobrecarga() : this("Metro")
    {
        
    }
    public Sobrecarga(string tipo)
    {
        tipoNumero = tipo;
    }

       */
       

    public class Sobrecarga
    {

        public string tipoNumero;

        public float Sumar(int a, int b)
        {   //método con dos parámetros
            if(tipoNumero == "Metro")
            return (a + b);       //de tipo int		
            else
            return (a + b) * 100;
        }

        public float Sumar(float a, float b)
        {   //método con dos parámetros
            return (int)(a + b);     //de tipo float		
        }

        public float Sumar(int a, float b)
        {   //método con dos parámetros
            return (float)(a + b);     //de tipo float		
        }

        public float Sumar(float a, int b)
        {   //método con dos parámetros
            return (float)(a +( b*100));     //de tipo float		
        }


    }
}
