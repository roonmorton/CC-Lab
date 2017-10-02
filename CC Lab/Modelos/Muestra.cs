using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class Muestra:DB
    {
        public void grabarModificar(string idMuestra, string descripcion)
        {
            try
            {
                ejecutarSP("SpGrabarModificarMuestra", null, Parametro("PidMuestra", idMuestra), Parametro("Pdescripcion", descripcion),Parametro("Pusuario",""));
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void eliminar(string idMuestra)
        {
            try
            {
                ejecutarSP("SPEliminarMuestra", null, Parametro("PidMuestra", idMuestra));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public System.Data.DataTable seleccionar(string descripcion)
        {
            try
            {
                return this.consultarTabla(@"SELECT IDMUESTRA, DESCRIPCION FROM MUESTRA WHERE DESCRIPCION LIKE '%" + descripcion + "%'");

            }catch(Exception){

                throw;
            }
        }
    }
}
