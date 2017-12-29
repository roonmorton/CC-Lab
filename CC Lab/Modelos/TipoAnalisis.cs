﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class TipoAnalisis : DB
    {

       
        public void grabarModificar(string TipoAnalisis, string descripcion)
        {
            try
            {
               // ejecutarSP("SpIuLinea", null, Parametro("@PidLinea", idLinea), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario), Parametro("@pidMarca", idMarca));

                //ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
                ejecutarSP("SpGrabarModificarTipoAnalisis",null,Parametro("@pidTipoAnalisis",TipoAnalisis),Parametro("@Pdescripcion",descripcion),Parametro("@Pusuario",Globals.usuario));
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
                return consultarTabla("SELECT idTipo_Analisis,DESCRIPCION FROM TIPO_ANALISIS");
                //MessageBox.Show(@"SELECT idTipo_Analisis,DESCRIPCION FROM TIPO_ANALISIS WHERE DESCRIPCION LIKE '%" + criterio + "%'");
                
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void eliminar(string idTipoAnalisis)
        {
            try
            {
                ejecutarSP("SpEliminarTipoAnalisis", null, Parametro("@PidtipoAnalisis",idTipoAnalisis));
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable seleccionarTipo(string idAnalisis)
        {
            try
            {
                return consultarTabla(@"SELECT TP.DESCRIPCION TIPOaNALISIS, AMTA.IDMUESTRA_TIPO_ANALISIS FROM TIPO_ANALISIS TP INNER JOIN MUESTRA_TIPO_ANALISIS MTA ON TP.IDTIPO_ANALISIS = MTA.IDTIPO_ANALISIS INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTA ON MTA.IDMUESTRA_TIPO_ANALISIS = AMTA.IDMUESTRA_TIPO_ANALISIS WHERE AMTA.IDANALISIS =" + idAnalisis);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
