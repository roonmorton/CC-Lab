using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class Reportes: DB
    {
        public DataTable obtenerResultado(string idAnalisis)
        {
            try
            {
                DataTable dt = consultarTabla(@"SELECT R.DESCRIPCION RESULTADO, RA.VALOR, R.VALORNORMAL, R.TIPOMEDIDA, A.FECHA, (P.NOMBRES + ' ' + P.APELLIDOS ) NOMBRES, YEAR(GETDATE()) - YEAR(P.FECHANACIMIENTO)EDAD,  (SELECT TP.DESCRIPCION FROM ANALISIS AA INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTP ON AA.IDANALISIS = AMTP.IDANALISIS INNER JOIN MUESTRA_TIPO_ANALISIS MTP ON MTP.IDMUESTRA_TIPO_ANALISIS = AMTP.IDMUESTRA_TIPO_ANALISIS INNER JOIN TIPO_ANALISIS TP ON TP.IDTIPO_ANALISIS = MTP.IDTIPO_ANALISIS  WHERE AA.IDANALISIS = A.IDANALISIS ) TIPO_ANALISIS FROM RESULTADO R INNER JOIN RESULTADO_ANALISIS RA ON RA.IDRESULTADO = R.IDRESULTADO LEFT JOIN ANALISIS A ON A.IDANALISIS = RA.IDANALISIS INNER JOIN PACIENTE P ON P.IDPACIENTE = A.IDPACIENTE where A.IDANALISIS = " + idAnalisis);
                DataTable dtTemp = dt;
                DataTable dtRes = new DataTable();
                

                foreach (DataRow row in dt.Rows)
                {
                    dtRes.Columns.Add(new DataColumn(row["resultado"].ToString()));
                    //dtRes.Columns.Add(new DataColumn("v_" + row["resultado"].ToString()));
                    dtRes.Columns.Add(new DataColumn("vn_" + row["resultado"].ToString()));
                    dtRes.Columns.Add(new DataColumn("tp_" + row["resultado"].ToString()));

                }

                DataRow dr = dtRes.NewRow();
                foreach (DataRow row in dtTemp.Rows)
                {
                    dr[row["resultado"].ToString()] = row["valor"].ToString();
                    dr[row["resultado"].ToString()] = row["valor"].ToString();
                    dr[row["resultado"].ToString()] = row["valor"].ToString();
                }
                dtRes.Rows.Add(dr);

                return dtRes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
