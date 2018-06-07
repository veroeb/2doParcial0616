using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Con array de RedSocial (Se necesita saber el largo del array)
            //RedSocial[] redesSociales = new RedSocial[3];
            //redesSociales[0] = new Facebook();
            //redesSociales[1] = new Instagram();
            //redesSociales[2] = new Twitter();

            //Compartir.CompartirFoto(redesSociales);
            #endregion

            #region Con lista
            Facebook facebook = new Facebook();
            Instagram instagram = new Instagram();
            Twitter twitter = new Twitter();

            List<RedSocial> redesSociales = new List<RedSocial>
            {
                facebook,
                instagram,
                twitter
            };

            Compartir.CompartirFoto(redesSociales);
            #endregion

            Console.ReadKey();
        }
    }
}
