using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab.Vistas.Movimientos
{
    public partial class FrmResultadoAnalisis : Form
    {
        private string idAnalisis = "0";
        private TipoAnalisis clsTipoAnalisis = new TipoAnalisis();
        private Reportes.Reportes clsReportes = new Reportes.Reportes();


        public FrmResultadoAnalisis(string idAnalisis)
        {
            InitializeComponent();
            this.idAnalisis = idAnalisis;
            
        }

        private void FrmResultadoAnalisis_Load(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void cargarGrid()
        {
            try
            {
                this.grdExistentes.DataSource = this.clsTipoAnalisis.seleccionarTipo(this.idAnalisis);
            }
            catch(Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        // Generar Reporte
                        
                        ReportViewer rw1 = new ReportViewer();

                        rw1.LocalReport.ReportPath = @"Reportes\rptOrinaEmbarazo.rdlc";
                            rw1.LocalReport.DataSources.Clear();
                            rw1.LocalReport.DataSources.Add(new ReportDataSource("DtsRecibo", this.clsReportes.obtenerResultado(
                                grdExistentes.SelectedRows[0].Cells["idmuestra_tipo_analisisCol"].Value.ToString()
                                )));

                            Warning[] warnings;
                            string[] streamids;
                            string mimeType;
                            string encoding;
                            string filenameExtension;
                            byte[] bytes = rw1.LocalReport.Render(
                                "PDF",null,out mimeType,out encoding, out filenameExtension,out streamids,out warnings);
                        using(FileStream fs = new FileStream("out.pdf",FileMode.Create))
                        {
                            fs.Write(bytes,0,bytes.Length);
                        }

//                        new Frm(grdExistentes.SelectedRows[0].Cells["idmuestra_tipo_analisisCol"].Value.ToString()).ShowDialog();

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        
        
        }
    }
}
