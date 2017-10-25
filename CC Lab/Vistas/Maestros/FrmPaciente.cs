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
    public partial class FrmPaciente : Form
    {

        private string idPaciente = "0";
        private Paciente clsPaciente = new Paciente();


        public FrmPaciente()
        {
            InitializeComponent();
        }

        public void buscar()
        {
            try
            {
                DataTable res = this.clsPaciente.buscar(this.txtNombres.Text.Trim(),this.txtApellidos.Text.Trim());
                this.grdExistentes.DataSource = res;
                this.lblExistentes.Text = res.Rows.Count.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            this.limpiarControles();
        }


        private void limpiarControles()
        {
            try
            {
                this.idPaciente = "0";
                this.txtNombres.Clear();
                this.txtApellidos.Clear();
                this.txtFechaNac.Clear();
                this.txtTelefono.Clear();
                this.txtDireccion.Clear();
                this.buscar();
                this.txtNombres.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errror: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombres.Text.Trim() != "" && this.txtApellidos.Text.Trim() != "")
                {
                    this.clsPaciente.GrabarModificar(this.idPaciente, this.txtNombres.Text.Trim(), this.txtApellidos.Text.Trim(), this.txtFechaNac.Text.Trim(), this.txtTelefono.Text.Trim(), this.txtDireccion.Text.Trim());
                    MessageBox.Show("Guardado correctamente");
                    this.limpiarControles();
                }
                else
                {
                    MessageBox.Show("Son necesarios los campos para poder procesar ");
                }
            }
            catch (Exception ex)
            {
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

                        this.idPaciente = grdExistentes.SelectedRows[0].Cells["idPacienteCol"].Value.ToString();
                        this.txtApellidos.Text = grdExistentes.SelectedRows[0].Cells["apellidosCol"].Value.ToString();
                        this.txtDireccion.Text = grdExistentes.SelectedRows[0].Cells["direccionCol"].Value.ToString();
                        this.txtFechaNac.Text = grdExistentes.SelectedRows[0].Cells["fechaNacimientoCol"].Value.ToString();
                        this.txtNombres.Text = grdExistentes.SelectedRows[0].Cells["nombresCol"].Value.ToString();
                        this.txtTelefono.Text = grdExistentes.SelectedRows[0].Cells["telefonoCol"].Value.ToString();
                        this.txtNombres.Focus();
                        break;

                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsPaciente.eliminar(grdExistentes.SelectedRows[0].Cells["idPacienteCol"].Value.ToString());
                            //this.clsMuestra.eliminar(grdExistentes.SelectedRows[0].Cells["idMuestraCol"].Value.ToString());
                            MessageBox.Show("Registro Eliminado");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                limpiarControles();
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        
        }

    }
}
