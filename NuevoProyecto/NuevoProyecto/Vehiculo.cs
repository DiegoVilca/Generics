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
        public string patente;


        public Vehiculo(string marca, string color, string patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("marca: " + this.marca);
            sb.AppendLine("color: " + this.color);
            sb.AppendLine("patente: " + this.patente);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            if (vehiculoUno.patente == vehiculoDos.patente)
            {
                return true;
            }

            return false;
        }

        public static bool operator != (Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        { 
            return !(vehiculoUno == vehiculoDos);
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
