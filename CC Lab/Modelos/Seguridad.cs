using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class Seguridad : DB
    {

        public System.Data.DataTable login(string usuario, string contrasena)
        {
            try
            {
                return consultarTabla("SPLogin",null,Parametro("@Pusuario",usuario),Parametro("@Pcontrasena",contrasena));
            }
            catch(Exception)
            {
                throw;
            }

        }
        public void cambioContrasena(string usuario, string antigua, string nueva)
        {
            try
            {
                ejecutarSP("SPCambioContrasena",null,Parametro("@Pusuario",usuario),Parametro("@Pantigua",antigua),Parametro("@Pnueva",nueva));
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
