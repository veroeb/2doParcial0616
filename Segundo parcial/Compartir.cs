using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_parcial
{
    public static class Compartir
    {
        #region Con array de RedSocial
        public static void CompartirFoto(RedSocial[] redesSociales)
        {
            foreach (RedSocial objRS in redesSociales)
            {
                objRS.SubirFoto();
            }
        }
        #endregion

        #region Con lista
        public static void CompartirFoto(List<RedSocial> ListaRedes)
        {
            foreach (RedSocial rs in ListaRedes)
            {
                rs.SubirFoto();
            }
        }
        #endregion
    }
}
