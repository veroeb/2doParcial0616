using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    abstract class CuerpoCeleste : SistemaSolar
    {
        public double Masa { get; set; }
        public abstract void Viajar();

        public CuerpoCeleste()
        {
            Nombre = "Cuerpo celeste";
        }
    }
}
