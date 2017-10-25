using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab
{
    public partial class FrmResultadoTipoResultado : Form
    {

        private Analisis clsAnalisis = new Analisis();
        string idMuestraTipoAnalisisResultado;

        public FrmResultadoTipoResultado(string idMuestraTipoAnalisisResultado,string titulo)
        {
            InitializeComponent();
            this.lblTitulo.Text = titulo;
            this.idMuestraTipoAnalisisResultado = idMuestraTipoAnalisisResultado;
            //MessageBox.Show("idMuestra Tipo analisis: " + this.idMuestraTipoAnalisis + "idtipo Res: " + this.idTipoResultado);
        }

        private void FrmResultadoTipoResultado_Load(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void cargarGrid()
        {
            try
            {
                this.grdExistentes.DataSource = this.clsAnalisis.selectTipoResultadoTipoResultado(this.idMuestraTipoAnalisisResultado);
               // this.grdExistentes.DataSource = this.clsAnalisis.selectTipoResultadoTipoResultado(this.idMuestraTipoAnalisis,this.idTipoResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //int idMuestra = Convert.ToInt32(cmbMuestra.SelectedValue); // idMuestra_tipo_analisis
           // string idTipoResultado;

            int acceso;
            /*
            int idRol = Convert.ToInt32(cboRol.SelectedValue);
            int idFormulario;
            string modo;
            int acceso;*/

            try
            {
                foreach (DataGridViewRow r in grdExistentes.Rows)
                {
                   // idTipoResultado = r.Cells["idTipo_resultadoCol"].Value.ToString();

                    //idTipoAnalisis = Convert.ToInt32(r.Cells["idTipo_analisisCol"].Value.ToString());
                    //MessageBox.Show("llego");
                    string idResultado = r.Cells["idResultadoCol"].Value.ToString();
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    //MessageBox.Show("acceso: " + acceso.ToString() + "id " + idTipoAnalisis.ToString());
                    // clsAnalisis.brindarDenegarAccesoTipoAnalisisMuestra(idMuestra, idTipoAnalisis, acceso);


                    this.clsAnalisis.brindarDenegarAccesoResultadoTipoResultado(this.idMuestraTipoAnalisisResultado, idResultado,acceso);
                   // this.clsAnalisis.brindarDenegarAccesoResultadoTipoAnalisis(this.idMuestraTipoAnalisis, this.idTipoResultado, idResultado, acceso);
                    //clsAnalisis.brindarDenegarAccesoTipoResultadoTipoAnalisis(this.idMuestraTipoAnalisis, idTipoResultado, acceso);
                    /*
                    idFormulario = Convert.ToInt32(r.Cells["idFormularioCol"].Value.ToString());
                    modo = r.Cells["modoCol"].Value.ToString();
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    ClsSeguridad.brindarDenegarAcceso(idFormulario, idRol, modo, acceso);*/
                }

                cargarGrid();
                MessageBox.Show("Proceso realizado con exitoAA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.cargarGrid();
            }
        }

        private void btnNuevoResultado_Click(object sender, EventArgs e)
        {
            new FrmResultado().ShowDialog();
            this.cargarGrid();
        }
    }
}
