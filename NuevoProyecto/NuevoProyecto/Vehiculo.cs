using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class Vehiculo
    {
        public string marca;
        public string color;
        public int patente;


        public Vehiculo(string marca, string color, int patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }

        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            if (vehiculoUno.patente == vehiculoDos.patente)
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            if (this == (Vehiculo)obj)
            {
                return true;
            }

            return false;
        }
    }
}
