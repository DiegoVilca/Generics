using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class Persona
    {
        public string nombre;
        public int dni;

        public Persona(string nombre, int dni)
        {
            this.dni = dni;
            this.nombre = nombre;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("nombre: " + this.nombre);
            sb.AppendLine("dni: " + this.dni);
            

            return sb.ToString();
        }


        public static bool operator ==(Persona personaUno, Persona personaDos)
        {
            if (personaUno.dni == personaDos.dni)
            {
                return true;
            }

            return false;
        
        }

        public static bool operator !=(Persona personaUno, Persona PersonaDos)
        {
            return !(personaUno == PersonaDos);
        }


        public override bool Equals(object obj)
        {
            if (this == (Persona)obj)
            {
                return true;
            }

            return false;
        }

    }
}
