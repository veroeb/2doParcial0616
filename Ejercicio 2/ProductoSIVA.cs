using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ProductoSIVA : Producto, IFacturaSIVA
    {
        public ProductoSIVA(string nombre, double precio) : base(nombre, precio)
        {
        }
    }
}
