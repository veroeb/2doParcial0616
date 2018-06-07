using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Asteroide : CuerpoCeleste
    {
        public Asteroide()
        {
            Nombre = "Asteroide";
            Masa = 70000;
        }
        public override void Viajar()
        {
            Console.WriteLine("Viajando por el espacio");
        }
    }
}
