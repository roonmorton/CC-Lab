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
    public partial class FrmMuestra : Form
    {
        private Muestra clsMuestra = new Muestra();
        private string idMuestra = "0";

        public FrmMuestra()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clsMuestra.grabarModificar(idMuestra, txtDescripcion.Text.Trim());
                MessageBox.Show("Guadado con exito...");
                limpiarControles();
            }
            catch (Exception ex)
            {
                this.idMuestra = "0";
                MessageBox.Show("A ocurrido un Error: " + ex.Message);
               // ClsHelper.erroLog(ex);
            }
        }


        private void limpiarControles()
        {
            try
            {
                this.txtDescripcion.Clear();
                this.idMuestra = "0";
                this.buscar();
                this.txtDescripcion.Focus();
            }
            catch (Exception)
            {

            }
        }


        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = this.clsMuestra.seleccionar(txtDescripcion.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido un Error: " + ex.Message);
            }
        }

        private void FrmMuestra_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        idMuestra = grdExistentes.SelectedRows[0].Cells["idMuestraCol"].Value.ToString();
                        txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                        txtDescripcion.Enabled = true;
                        txtDescripcion.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsMuestra.eliminar(grdExistentes.SelectedRows[0].Cells["idMuestraCol"].Value.ToString());
                            MessageBox.Show("Registro Eliminado");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idMuestra = "0";
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }
    }
}
