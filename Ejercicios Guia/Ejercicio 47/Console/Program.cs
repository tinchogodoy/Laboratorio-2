using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo;

namespace Consolear
{
    class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>();
            Torneo<EquipoBasquet> torneoBasket = new Torneo<EquipoBasquet>();

            EquipoBasquet equipoBasquet = new EquipoBasquet();
            equipoBasquet.fechaCreacion = new DateTime(1989, 10, 5);
            equipoBasquet.nombre = "Los wachines";
            torneoBasket = torneoBasket + equipoBasket;
            EquipoBasquet equipoBasket2 = new EquipoBasquet();
            equipoBasket2.fechaCreacion = new DateTime(2007, 5, 5);
            equipoBasket2.nombre = "Los pepitos";
            torneoBasket = torneoBasket + equipoBasquet2;
            EquipoFutbol equipoFutbol = new EquipoFutbol();
            equipoFutbol.nombre = "Boquita";
            equipoFutbol.fechaCreacion = new DateTime(1905, 5, 13);
            torneoFutbol += equipoFutbol;
            EquipoFutbol equipoFutbol2 = new EquipoFutbol();
            EquipoFutbol equipoFutbol3 = new EquipoFutbol();
            equipoFutbol2.nombre = "UTN";
            equipoFutbol2.fechaCreacion = new DateTime(2000, 8, 19);
            equipoFutbol3.nombre = "peperoni";
            equipoFutbol3.fechaCreacion = new DateTime(1889, 8, 24);

            Torneo<EquipoBasket>.Mostrar(torneoBasket);
            

            Console.ReadKey();
        }
    }
}
/*Crear un proyecto del tipo Console:
i.Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet.
ii.Crear 3 equipos de cada tipo.
iii.Agregar los equipos en tantos torneos como se pueda.
iv.Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
v.Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su
respuesta por pantalla.*/
