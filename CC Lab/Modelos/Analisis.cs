using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class Analisis : DB
    {
        public DataTable seleccionarMuestra()
        {
            try
            {
                return ejecutarSPdt("SPsMuestra",null);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable selectTipoAnalisisMuestra(int idMuestra)
        {
            try
            {
                return ejecutarSPdt("SPsTipoAnalisisMuestra",null,Parametro("@pidMuestra",idMuestra.ToString()));
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void brindarDenegarAcceso(int idMuestra,int idTipoAnalisis, int acceso)
        {
            try
            {
                ejecutarSP("SPVincularTipoAnalisisMuestra",null,Parametro("@pidMuestra",idMuestra.ToString()),
                    Parametro("@pidTipoAnalisis",idTipoAnalisis.ToString()),Parametro("@Pacceso",acceso.ToString()));
            }
            catch(Exception)
            {
                throw;
            }

        }
    }
}
