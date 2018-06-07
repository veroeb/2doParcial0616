using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elementos = new string[2];
            elementos[0] = "hola";
            elementos[1] = "chau";

            try
            {
                /* Con singleton                
                Buscador.GetInstancia().GetElemento(elementos, 3);
                */
                Buscador buscador = new Buscador();
                buscador.GetElemento(elementos, 3);
            }
            catch(FueraDeRangoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
