using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class Resultado:DB
    {
        public DataTable seleccionar(string criterio)
        {
            try
            {
                return consultarTabla(@"SELECT IDRESULTADO,DESCRIPCION,VALORNORMAL,TIPOMEDIDA FROM RESULTADO WHERE DESCRIPCION LIKE '%" + criterio + "%'");
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void grabarModificar(string idResultado, string descripcion, string valorNormal, string tipoMedida)
        {
            try
            {
                ejecutarSP("[SpGrabarModificarResultado]", null, Parametro("@pidResultado", idResultado), Parametro("@Pdescripcion", descripcion), Parametro("@PvalorNormal", valorNormal)
                    , Parametro("@pTipoMedida",tipoMedida),Parametro("@pUsuario",Globals.usuario));
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void eliminar(string idResultado)
        {
            try
            {
                ejecutarSP("SpEliminarResultado",null,Parametro("@pIdResultado",idResultado));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
