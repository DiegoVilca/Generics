using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito<Producto> depositoProducto = new Deposito<Producto>(3);
            Deposito<Persona> depositoPersona = new Deposito<Persona>(3);
            Deposito<Vehiculo> depositoVehiculo = new Deposito<Vehiculo>(3);
            Deposito<Mascota> depositoMascota = new Deposito<Mascota>(3);

            //Producto producto = new Producto();
            //Persona persona = new Persona("Diego", 35444666);
            //Vehiculo vehiculo = new Vehiculo("Ford", "Azul", 654987);
            //Mascota mascota = new Mascota("Pipo", "Caniche");

            depositoProducto.Agregar(new Producto(1, "yogur", 20));
            depositoProducto.Agregar(new Producto(2, "galletitas", 15));
            depositoProducto.Agregar(new Producto(3, "arroz", 25));

            foreach (Producto item in depositoProducto)
            {
                Console.WriteLine(item.ToString());
            }

            depositoPersona.Agregar(new Persona("Diego", 35665478));
            depositoPersona.Agregar(new Persona("Ivan", 38451222));
            depositoPersona.Agregar(new Persona("Hugo", 33354987));

            foreach (Persona item in depositoPersona)
            {
                Console.WriteLine(item.ToString());
            }

            depositoVehiculo.Agregar(new Vehiculo ("Ford", "Azul", "wer456"));
            depositoVehiculo.Agregar(new Vehiculo("Peugeot", "Marron", "jjj654"));
            depositoVehiculo.Agregar(new Vehiculo("Citroen", "Negro", "opo756"));

            foreach (Vehiculo item in depositoVehiculo)
            {
                Console.WriteLine(item.ToString());
            }


            depositoMascota.Agregar(new Mascota ("Michifuz", "Siames"));
            depositoMascota.Agregar(new Mascota("Michifuz", "Siames"));
            depositoMascota.Agregar(new Mascota("Michifuz", "Siames"));

            foreach (Mascota item in depositoMascota)
            {
                Console.WriteLine(item.ToString());
            }

            

            Console.ReadKey();
            

        }
    }
}
