using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class TipoAnalisis : DB
    {

       
        public void grabarModificar(string idLinea, string nombre, string idMarca)
        {
            try
            {
               // ejecutarSP("SpIuLinea", null, Parametro("@PidLinea", idLinea), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario), Parametro("@pidMarca", idMarca));

                //ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
