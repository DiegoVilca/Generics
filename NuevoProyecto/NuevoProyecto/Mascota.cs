using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("nombre: " + this.nombre);
            sb.AppendLine("raza: " + this.raza);
            

            return sb.ToString();
        }


        public static bool operator ==(Mascota mascotaUno, Mascota mascotaDos)
        {
            if (mascotaUno.nombre == mascotaDos.nombre && mascotaUno.raza== mascotaDos.raza)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Mascota mascotaUno, Mascota mascotaDos)
        {
            return !(mascotaUno == mascotaDos);
        }

        public override bool Equals(object obj)
        {
            if (this == (Mascota)obj)
            {
                return true;
            }

            return false;
        }

    }
}
