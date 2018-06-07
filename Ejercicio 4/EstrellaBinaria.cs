using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class EstrellaBinaria : Estrella
    {
        public EstrellaBinaria()
        {
            Nombre = "Estrella binaria";
            Masa = 5000000;
        }
        public override void Viajar()
        {
            Console.WriteLine("Viajando por el espacio");
        }
    }
}
