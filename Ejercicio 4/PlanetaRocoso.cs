using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class PlanetaRocoso : Planeta
    {
        public PlanetaRocoso()
        {
            Nombre = "Planeta rocoso";
            Masa = 70000000;
        }
        public override void Viajar()
        {
            Console.WriteLine("Viajando por el espacio");
        }
    }
}
