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
    public partial class FrmNuevoAnalisis : Form
    {
        private string idAnalisis = "0";
        private string idPaciente = "0";
        private Analisis clsAnalisis = new Analisis();
        private Paciente clsPaciente = new Paciente();

        public FrmNuevoAnalisis()
        {
            InitializeComponent();
        }

        private void FrmNuevoAnalisis_Load(object sender, EventArgs e)
        {
            this.txtFecha.Text = DateTime.Now.ToString();
            cargarComboMuestra();
            cargarGrid();
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
                grdExistentes.DataSource = clsAnalisis.seleccionarTipoAnalisisporMuestra(cmbMuestra.SelectedValue.ToString());
                
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCarnetPaciente.Text.Trim() != "")
                {
                    DataTable res = this.clsPaciente.seleccionarPaciente(this.txtCarnetPaciente.Text.Trim());
                    if (res.Rows.Count > 0)
                    {
                        this.txtCarnetPaciente.Enabled = false;
                        this.btnBuscar.Enabled = false;
                        this.txtNombres.Text = res.Rows[0]["nombres"].ToString();
                        this.txtDireccion.Text = res.Rows[0]["direccion"].ToString();
                        this.txtEdad.Text = res.Rows[0]["edad"].ToString();
                        this.txtTelefono.Text = res.Rows[0]["telefono"].ToString();
                                           
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el paciente");
                        this.txtCarnetPaciente.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar carnet de paciente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void limpiarControles()
        {
            try
            {
                this.txtTelefono.Clear();
                this.txtNombres.Clear();
                this.txtEdad.Clear();
                this.txtDireccion.Clear();
                this.txtCarnetPaciente.Clear();
                this.txtCarnetPaciente.Enabled = true;
                this.txtCarnetPaciente.Focus();
                this.btnBuscar.Enabled = true;
                idAnalisis = "0";
                cargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();   
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (verificarSeleccionAnalisis())
                {
                    DataTable dtAnalisis = this.clsAnalisis.nuevoAnalisis(this.txtFecha.Text.Trim(), this.txtCarnetPaciente.Text.Trim(), this.idAnalisis);
                    if (dtAnalisis.Rows.Count > 0)
                    {
                        idAnalisis = dtAnalisis.Rows[0]["idAnalisis"].ToString();
                        foreach (DataGridViewRow r in grdExistentes.Rows)
                        {
                            string idMuestra_tipo_analisis = r.Cells["idMuestra_tipo_analisisCol"].Value.ToString();
                            int acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                            if (acceso == 1)
                            {
                                this.clsAnalisis.agregarTiposExamen(this.idAnalisis, idMuestra_tipo_analisis);
                            }
                        }

                        MessageBox.Show("Proceso realizado con exito");
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se logro generar Analisis, contacte con Soporte");
                    }
                    //                cargarGrid();
                }
                else
                {
                    MessageBox.Show("Verificar la informacion ingresada (Paciente, Tipo analisis seleccionado)...");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error002: " + ex.Message);
                this.cargarGrid();
            }
        }

        private Boolean verificarSeleccionAnalisis()
        {
            Boolean res = false;
            try
            {
                if (this.grdExistentes.Rows.Count > 0)
                { 
                    foreach (DataGridViewRow r in grdExistentes.Rows)
                    {
                        int acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                        if (acceso == 1)
                        {
                            res = true;
                        }
                    }
                    if (res) 
                    {
                        if (this.txtCarnetPaciente.Text == "" || (this.txtCarnetPaciente.Enabled) == true)
                                          //MessageBox.Show("Paciente no validado");
                            res = false;
                    }
                }
                else
                {
                    MessageBox.Show("Error, no se encontraron datos ha habilitar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 001: " + ex.Message + ex.StackTrace + ex.Source + ex.TargetSite + ex.InnerException + ex.HelpLink);
            }
            return res;
        }
    }
}
