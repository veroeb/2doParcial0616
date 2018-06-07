using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductoIVA productoIVA = new ProductoIVA("MacBook", 2400);
            ProductoSIVA productoSIVA = new ProductoSIVA("Banana", 20);

            List<Producto> ListaProductos = new List<Producto>
            {
                productoIVA,
                productoSIVA
            };

            Calculador.CalcularFactura(ListaProductos);

            Console.ReadKey();
        }
    }
}
