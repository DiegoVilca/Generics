using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class Producto
    {
        public int codigo;
        public string descripcion;
        public double precioDeVenta;


        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return productoUno.codigo == productoDos.codigo;
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("codigo: "+this.codigo);
            sb.AppendLine("descripcion: " + this.descripcion);
            sb.AppendLine("precio: " + this.precioDeVenta);

            return sb.ToString();
        }


        public override bool Equals(object obj)
        {
            if (this == (Producto)obj)
            {
                return true;
            }

            return false;
        }

    }
}
