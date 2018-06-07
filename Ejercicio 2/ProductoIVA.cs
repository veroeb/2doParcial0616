using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ProductoIVA : Producto, IFacturaIVA
    {
        public ProductoIVA(string nombre, double precio) : base(nombre, precio)
        {
            Precio += Precio * 0.22;
        }
    }
}
