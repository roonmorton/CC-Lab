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
    public partial class FrmAnalisis : Form
    {
        Analisis clsAnalisis = new Analisis();

        public FrmAnalisis()
        {
            InitializeComponent();
        }

        
        private void FrmAnalisis_Load(object sender, EventArgs e)
        {
            this.cargarComboMuestra();
            this.cargarGrid();
        }
        private void cargarComboMuestra()
        {
            try
            {
                cmbMuestra.DataSource = clsAnalisis.seleccionarMuestra();
                cmbMuestra.ValueMember = "idMuestra";
                cmbMuestra.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error " + ex.Message);
            }
        }

        private void cargarGrid()
        {
            //Llenar Grid
            try
            {

                //Llenar grid
                grdExistentes.DataSource = clsAnalisis.selectTipoAnalisisMuestra(Convert.ToInt32(cmbMuestra.SelectedValue));
                //llena grid
                /*grdDetalle.DataSource = ClsSeguridad.selecFormulariosRol(Convert.ToInt32(cboRol.SelectedValue));
                //columna combobox
                DataTable dtModo = new DataTable();
                dtModo.Columns.Add("codigo");
                dtModo.Columns.Add("descripcion");
                dtModo.Rows.Add("0X", "0X-Sistemas");
                dtModo.Rows.Add("0X", "0A-Administrador");
                dtModo.Rows.Add("0X", "0T-Usuario estándar");
                foreach (DataGridViewRow row in grdDetalle.Rows)
                {
                    ComboBox cbo = new ComboBox();
                    cbo.DataSource = dtModo;
                    cbo.DisplayMember = "descripcion";
                    cbo.ValueMember = "codigo";
                    cbo.SelectedValue = row.Cells["modoCol"].Value;

                    //DataGridViewComboBoxCell comboModo = new DataGridViewComboBoxCell();
                    //comboModo = (DataGridViewComboBoxCell)(row.Cells["modoCol"]);

                    //comboModo.DataSource = dtModo;
                    //comboModo.DisplayMember = "descripcion";
                    //comboModo.ValueMember = "codigo";
                }*/
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbMuestra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idMuestra = Convert.ToInt32(cmbMuestra.SelectedValue);
            int idTipoAnalisis;
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
                    idTipoAnalisis = Convert.ToInt32(r.Cells["idTipo_analisisCol"].Value.ToString());
                    //MessageBox.Show("llego");
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    //MessageBox.Show("acceso: " + acceso.ToString() + "id " + idTipoAnalisis.ToString());
                    clsAnalisis.brindarDenegarAcceso(idMuestra,idTipoAnalisis,acceso);
                    /*
                    idFormulario = Convert.ToInt32(r.Cells["idFormularioCol"].Value.ToString());
                    modo = r.Cells["modoCol"].Value.ToString();
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    ClsSeguridad.brindarDenegarAcceso(idFormulario, idRol, modo, acceso);*/
                }

                cargarGrid();
                MessageBox.Show("Proceso realizado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.cargarGrid();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new FrmMuestra().ShowDialog();
            this.cargarComboMuestra();
            this.cargarGrid();
        }

    }
}
