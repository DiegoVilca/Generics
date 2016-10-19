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

            Producto producto = new Producto();
            Persona persona = new Persona("Diego", 35444666);
            Vehiculo vehiculo = new Vehiculo("Ford", "Azul", 654987);
            Mascota mascota = new Mascota("Pipo", "Caniche");

            depositoProducto.Agregar(producto);
            depositoPersona.Agregar(persona);
            depositoVehiculo.Agregar(vehiculo);
            depositoMascota.Agregar(mascota);

            Console.ReadKey();
            

        }
    }
}
