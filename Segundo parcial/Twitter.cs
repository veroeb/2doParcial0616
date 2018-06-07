using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_parcial
{
    public class Twitter : RedSocial
    {
        public override void SubirFoto()
        {
            NombreRS = "Twitter";
            Console.WriteLine("Ha subido una foto a Twitter");
        }
    }
}
