using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    abstract class Estrella : CuerpoCeleste
    {
        public Estrella()
        {
            Nombre = "Estrella";
        }
        public override void Viajar()
        {
            Console.WriteLine("Viajando por el espacio");
        }
    }
}
