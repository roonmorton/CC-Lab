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


        public DataTable selectTipoResultadoTipoResultado(string idMuestraTipoAnalisisResultado)
        {
            try
            {
                return ejecutarSPdt("SPsResultadoTipoResultado", null, Parametro("@pidmuestra_tipo_analisis_resultado", idMuestraTipoAnalisisResultado));
            }
            catch (Exception)
            {
                throw;
            }

        }


        public DataTable selecttipoResultadoTipoAnalisis(string idMuestraTipoAnalisis)
        {
            try
            {
                return ejecutarSPdt("SPsTipoResultadoTipoAnalisis", null, Parametro("@PidMuestraTipoAnalisis", idMuestraTipoAnalisis));
            }
            catch (Exception)
            {
                throw;
            }

        }


        public void brindarDenegarAccesoTipoAnalisisMuestra(int idMuestra,int idTipoAnalisis, int acceso)
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

        public void brindarDenegarAccesoTipoResultadoTipoAnalisis(string idMuestraTipoAnalisis, string idTipoResultado, int acceso)
        {
            try
            {
                ejecutarSP("SPVincularTipoResultadoTipoAnalisis", null, 
                    Parametro("@pidMuestraTipoAnalisis", idMuestraTipoAnalisis.ToString()),
                    Parametro("@pidTipoResultado", idTipoResultado.ToString()), 
                    Parametro("@Pacceso", acceso.ToString()));
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void brindarDenegarAccesoResultadoTipoResultado(string idMuestraTipoAnalisisResultado, string idResultado, int acceso)
        {
            try
            {
                ejecutarSP("SPVincularResultadoTipoAnalisis", null, 
                    Parametro("@pidMuestraTipoAnalisisResultado", idMuestraTipoAnalisisResultado),
                    //Parametro("@pidTipoResultado", idTipoResultado),
                    Parametro("@PidResultado",idResultado), 
                    Parametro("@Pacceso", acceso.ToString()));
            }
            catch (Exception)
            {
                throw;
            }

        }



        public DataTable seleccionarTipoAnalisisporMuestra(string idMuestra)
        {
            try
            {
                return consultarTabla(@"SELECT  0 acceso, b.IDMUESTRA_TIPO_ANALISIS, a.DESCRIPCION, c.IDMUESTRA, c.DESCRIPCION as muestra  FROM TIPO_ANALISIS AS a LEFT OUTER JOIN MUESTRA_TIPO_ANALISIS AS b ON a.IDTIPO_ANALISIS = b.IDTIPO_ANALISIS INNER JOIN MUESTRA AS c ON C.IDMUESTRA = b.IDMUESTRA WHERE c.IDMUESTRA = " + idMuestra);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable nuevoAnalisis(string fecha,string idPaciente,string idAnalisis)
        {
            try
            {
                return ejecutarSPdt("SpNuevoAnalisis",null,Parametro("@pfecha",fecha),Parametro("@pidPaciente",idPaciente),Parametro("@PidAnalisis",idAnalisis),Parametro("@Pusuario",Globals.usuario));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void agregarTiposExamen(string idAnalisis, string id_muestra_tipo_analisis)
        {
            try
            {
                consultarTabla(@"INSERT INTO ANALISIS_MUESTRA_TIPO_ANALISIS(IDANALISIS,IDMUESTRA_TIPO_ANALISIS) VALUES( " + idAnalisis + "," + id_muestra_tipo_analisis + ")");
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable buscarAnalisis(string nombrePaciente)
        {
            try
            {
                return consultarTabla(@"SELECT (CASE WHEN (AN.FECHA_ENTREGA IS NULL)  AND (AN.FECHA_COMPLETADO IS NULL) THEN 'EN LABORATORIO' WHEN (AN.FECHA_ENTREGA IS NULL)  AND (AN.FECHA_COMPLETADO IS NOT NULL) THEN 'PARA ENTREGA' ELSE 'ENTREGADO' END )AS ESTADO , AN.IDANALISIS,AN.FECHA, (PA.NOMBRES + ' ' + PA.APELLIDOS) AS NOMBRES , ( SELECT MUESTRA.DESCRIPCION FROM MUESTRA LEFT JOIN MUESTRA_TIPO_ANALISIS ON MUESTRA.IDMUESTRA = MUESTRA_TIPO_ANALISIS.IDMUESTRA INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS  ON MUESTRA_TIPO_ANALISIS.IDMUESTRA_TIPO_ANALISIS  = ANALISIS_MUESTRA_TIPO_ANALISIS.IDMUESTRA_TIPO_ANALISIS WHERE IDANALISIS = an.IDANALISIS GROUP BY MUESTRA.DESCRIPCION ) MUESTRA, ( SELECT (STUFF(( SELECT ', ' + TIPO_ANALISIS.DESCRIPCION FROM ANALISIS INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS ON ANALISIS.IDANALISIS = ANALISIS_MUESTRA_TIPO_ANALISIS.IDANALISIS INNER JOIN MUESTRA_TIPO_ANALISIS ON ANALISIS_MUESTRA_TIPO_ANALISIS.IDMUESTRA_TIPO_ANALISIS = MUESTRA_TIPO_ANALISIS.IDMUESTRA_TIPO_ANALISIS INNER JOIN TIPO_ANALISIS ON TIPO_ANALISIS.IDTIPO_ANALISIS = MUESTRA_TIPO_ANALISIS.IDTIPO_ANALISIS WHERE ANALISIS.IDANALISIS = AN.IDANALISIS for xml path('')),1,1,'')) ) AS ANALISIS FROM ANALISIS AS an INNER JOIN PACIENTE AS pa on pa.IDPACIENTE = an.IDPACIENTE  WHERE PA.NOMBRES like '%" + nombrePaciente + "%' OR pa.APELLIDOS like '%" + nombrePaciente + "%'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable generarResultados(string idAnalisis)
        {
            try
            {
                return consultarTabla(@"SELECT TA.DESCRIPCION TIPO_ANALISIS, TR.DESCRIPCION TIPO_RESULTADO, R.DESCRIPCION RESULTADO, R.IDRESULTADO, R.TIPOMEDIDA, R.VALORNORMAL FROM ANALISIS AN INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS amta ON AN.IDANALISIS = amta.IDANALISIS INNER JOIN MUESTRA_TIPO_ANALISIS MTA ON MTA.IDMUESTRA_TIPO_ANALISIS = amta.IDMUESTRA_TIPO_ANALISIS INNER JOIN TIPO_ANALISIS TA ON TA.IDTIPO_ANALISIS = MTA.IDTIPO_ANALISIS INNER JOIN MUESTRA_TIPO_ANALISIS_RESULTADO MTAR ON MTA.IDMUESTRA_TIPO_ANALISIS = MTAR.IDMUESTRA_TIPO_ANALISIS INNER JOIN TIPO_RESULTADO TR ON TR.IDTIPO_RESULTADO = MTAR.IDTIPO_RESULTADO INNER JOIN RESULTADO_TIPO_RESULTADO RTR ON MTAR.IDMUESTRA_TIPO_ANALISIS_RESULTADO = RTR.IDMUESTRA_TIPO_ANALISIS_RESULTADO INNER JOIN RESULTADO R ON R.IDRESULTADO = RTR.IDRESULTADO WHERE AN.IDANALISIS = " + idAnalisis);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable obtenerPaciente(string idAnalisis)
        {
            try
            {
                return consultarTabla("SELECT (PACIENTE.NOMBRES + ' ' + PACIENTE.APELLIDOS) AS NOMBRES, ANALISIS.FECHA, YEAR(GETDATE()) - YEAR(PACIENTE.FECHANACIMIENTO)EDAD FROM ANALISIS  INNER JOIN PACIENTE ON ANALISIS.IDPACIENTE = PACIENTE.IDPACIENTE WHERE ANALISIS.IDANALISIS = "+ idAnalisis);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
