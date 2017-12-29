using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab.Reportes
{
    class Reportes: DB
    {
        public DataTable obtenerResultado(string idMuestraTipoAnalisis)
        {
            try
            {
                DataTable dt = consultarTabla(@"SELECT R.DESCRIPCION RESULTADO, RA.VALOR, R.VALORNORMAL, R.TIPOMEDIDA, A.FECHA, M.DESCRIPCION MUESTRA FROM RESULTADO R LEFT JOIN RESULTADO_ANALISIS RA ON R.IDRESULTADO = RA.IDRESULTADO INNER JOIN ANALISIS A ON A.IDANALISIS = RA.IDANALISIS INNER JOIN ANALISIS_MUESTRA_TIPO_ANALISIS AMTA ON A.IDANALISIS = AMTA.IDANALISIS INNER JOIN MUESTRA_TIPO_ANALISIS MTA ON MTA.IDMUESTRA_TIPO_ANALISIS = AMTA.IDMUESTRA_TIPO_ANALISIS INNER JOIN TIPO_ANALISIS TA ON TA.IDTIPO_ANALISIS = MTA.IDTIPO_ANALISIS INNER JOIN MUESTRA M  ON M.IDMUESTRA = MTA.IDMUESTRA WHERE MTA.IDMUESTRA_TIPO_ANALISIS =" + idMuestraTipoAnalisis);
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

                //MessageBox.Show("filas: " + dtRes.Rows.Count.ToString());
                return dtRes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
