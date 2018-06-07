using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class SistemaSolar : IGalaxia
    {
        public string Nombre { get; set; }

        public SistemaSolar()
        {
            Nombre = "Sistema Solar";
        }
    }
}
