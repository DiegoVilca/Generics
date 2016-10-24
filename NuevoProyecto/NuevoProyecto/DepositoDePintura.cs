using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class DepositoDePintura
    {
        public List<Producto> listaProductos;
        public int cantMaxima;


        //constructor

        public DepositoDePintura(int cantMaxima)
        {
            this.cantMaxima = cantMaxima;

            listaProductos = new List<Producto>();
        }

        //metodos

        public bool NoHayLugar()
        {
            return this.cantMaxima == this.listaProductos.Count;
        }


        public bool ExisteElemento(Producto producto)
        {
            foreach (Producto item in this.listaProductos)
            {
                if (item == producto)
                {
                    return true;
                }
            }

            return false;
        }



        public bool Agregar(Producto producto)
        {
            return this + producto;
        }




        public static bool operator +(DepositoDePintura deposito, Producto producto)
        {

            if (!deposito.NoHayLugar() && !deposito.ExisteElemento(producto))
	        {
		        deposito.listaProductos.Add(producto);

                return true;
	        }

                return false;
        }

    }
}
