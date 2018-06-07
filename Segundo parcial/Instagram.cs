using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_parcial
{
    public class Instagram : RedSocial
    {
        public override void SubirFoto()
        {
            NombreRS = "Instagram";
            Console.WriteLine("Ha subido una foto a Instagram");
        }
    }
}
