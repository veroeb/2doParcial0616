using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public class Buscador
    {
        #region Singleton
        private static Buscador instancia;

        public static Buscador GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Buscador();
            }

            return instancia;
        }
        #endregion

        public void GetElemento(string[] elementos, int idx)
        {
            if (elementos.Count() < idx || idx < 0)
            {
                throw new IndexOutOfRangeException("Está fuera del rango en el array");     //No se puede heredar de IndexOutOfRangeException, la clase está sealed
            }
            else
                throw new Exception();
        }
    }
}
