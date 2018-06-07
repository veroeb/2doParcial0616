using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_parcial
{
    public class Facebook : RedSocial
    {
        public override void SubirFoto()
        {
            NombreRS = "Facebook";
            Console.WriteLine("Ha subido una foto a Facebook");
        }
    }
}
