using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class TipoResultado:DB
    {
        public void grabarModificar(string idTipoResultado, string descripcion)
        {
            try
            {
                // ejecutarSP("SpIuLinea", null, Parametro("@PidLinea", idLinea), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario), Parametro("@pidMarca", idMarca));

                //ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
                ejecutarSP("SpGrabarModificarTipoResultado", null, Parametro("@pidTipoResultado", idTipoResultado), Parametro("@Pdescripcion", descripcion), Parametro("@Pusuario", Globals.usuario));
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable seleccionar(string criterio)
        {
            try
            {
                return consultarTabla(@"SELECT  IDTIPO_RESULTADO,DESCRIPCION FROM TIPO_RESULTADO WHERE DESCRIPCION LIKE '%"+ criterio + "%'");
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void eliminar(string idTipoResultado)
        {
            try
            {
                ejecutarSP("SpEliminarTipoResultado", null, Parametro("@PidtipoResultado", idTipoResultado));
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
