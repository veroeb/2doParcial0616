using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public static class Calculador
    {
        //private static List<Producto> ListaProductos;

        //public static Calculador()
        //{
        //    ListaProductos = new List<Producto>(); 
        //}

        //public static void AgregarProducto(Producto producto)
        //{
        //    ListaProductos.Add(producto);
        //}

        public static void CalcularFactura(List<Producto> ListaProductos)
        {
            foreach(Producto p in ListaProductos)
            {
                Console.WriteLine($"Nombre del producto: {p.Nombre}, precio final: {p.Precio}");
            }
        }
    }
}
