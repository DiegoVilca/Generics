using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    public class Deposito<T> : IEnumerable<T>
    {
        public List<T> listaProductos;
        public int cantMaxima;


        //constructor

        public Deposito(int cantMaxima)
        {
            this.cantMaxima = cantMaxima;

            listaProductos = new List<T>();
        }

        //metodos

        public bool NoHayLugar()
        {
            return this.cantMaxima == this.listaProductos.Count;
        }



        public bool ExisteElemento(T producto)
        {
            foreach (T item in this.listaProductos)
            {
                if (item.Equals(producto)) //Como Deposito es clase generica no puedo usar la sobrecarga == ya que no sabe que comparar
                {                           //En su lugar utilizo el Equals sobrecargado, cada clase que almacene Deposito 
                    return true;             //Tendra su Equals sobrecargado.
                }
            }

            return false;
        }



        public bool Agregar(T producto)
        {
            return this + producto;
        }


        public static bool operator +(Deposito<T> deposito, T producto)
        {

            if (!deposito.NoHayLugar() && !deposito.ExisteElemento(producto))
	        {
		        deposito.listaProductos.Add(producto);

                return true;
	        }

                return false;
        }



        //Implemento la interfaz IEnumerable para poder iterar en el program la lista<T>

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.listaProductos)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
