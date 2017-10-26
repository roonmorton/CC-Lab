using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab.Vistas.Movimientos
{
    public partial class FrmIngresoResultado : Form
    {
        private string idAnalisis = "0",muestra = "";
        private Analisis clsAnalsis = new Analisis();

        public FrmIngresoResultado(string idAnalisis,string muestra)
        {
            InitializeComponent();
            this.idAnalisis = idAnalisis;
            this.muestra = muestra;
        }

        private void FrmIngresoResultado_Load(object sender, EventArgs e)
        {
            this.txtFecha.Text = DateTime.Now.ToString();
            this.cargarInformacion();
        }


        private void cargarInformacion()
        {
            try
            {
                this.grdExistentes.DataSource = clsAnalsis.generarResultados(this.idAnalisis);
                DataTable resPaciente = clsAnalsis.obtenerPaciente(this.idAnalisis);
                this.txtPaciente.Text = resPaciente.Rows[0]["nombres"].ToString();
                this.txtFechaAnalisis.Text = resPaciente.Rows[0]["fecha"].ToString();
                this.txtEdad.Text = resPaciente.Rows[0]["edad"].ToString();
                this.txtMuestra.Text = this.muestra;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string idResultado = "",valor = "";
                foreach (DataGridViewRow r in grdExistentes.Rows)
                {

                    idResultado = r.Cells["idResultadoCol"].Value.ToString();
                    valor = r.Cells["vResultadoCol"].Value.ToString();

                    clsAnalsis.registrarResultado(idResultado, this.idAnalisis, valor);
                    //idTipoResultado = r.Cells["idTipo_resultadoCol"].Value.ToString();
                    //idTipoAnalisis = Convert.ToInt32(r.Cells["idTipo_analisisCol"].Value.ToString());
                    //MessageBox.Show("llego");
                    //acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    //MessageBox.Show("acceso: " + acceso.ToString() + "id " + idTipoAnalisis.ToString());
                    // clsAnalisis.brindarDenegarAccesoTipoAnalisisMuestra(idMuestra, idTipoAnalisis, acceso);
                    //clsAnalisis.brindarDenegarAccesoTipoResultadoTipoAnalisis(this.idMuestraTipoAnalisis, idTipoResultado, acceso);
                    /*
                    idFormulario = Convert.ToInt32(r.Cells["idFormularioCol"].Value.ToString());
                    modo = r.Cells["modoCol"].Value.ToString();
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    ClsSeguridad.brindarDenegarAcceso(idFormulario, idRol, modo, acceso);*/
                }
                this.clsAnalsis.completarRegistroResultados(this.idAnalisis);
                MessageBox.Show("Proceso realizado con exito");
                this.grdExistentes.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 0: " + ex.Message);
            }
        }

        
    }
}
