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
    public partial class FrmTipoResultado : Form
    {

        private string idTipoResultado = "0";
        private TipoResultado clsTipoResultado = new TipoResultado();


        public FrmTipoResultado()
        {
            InitializeComponent();
            
        }


        private void buscar()
        {
            try
            {
                DataTable dt = this.clsTipoResultado.seleccionar(this.txtDescripcion.Text.Trim());
                this.grdExistentes.DataSource = dt;
                this.lblExistentes.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmTipoResultado_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDescripcion.Text.Trim() != "")
                {
                    this.clsTipoResultado.grabarModificar(this.idTipoResultado, this.txtDescripcion.Text.Trim());
                    MessageBox.Show("Alamacenado correctamente");
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("Debe de Ingresar un valor en descripción....");
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
                this.txtDescripcion.Clear();
                this.buscar();
                this.idTipoResultado = "0";
                this.txtDescripcion.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.idTipoResultado = grdExistentes.SelectedRows[0].Cells["idTipo_resultadoCol"].Value.ToString();
                        this.txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                        this.txtDescripcion.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsTipoResultado.eliminar(grdExistentes.SelectedRows[0].Cells["idTipo_resultadoCol"].Value.ToString());
                            MessageBox.Show("Registro Eliminado");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idTipoResultado = "0";
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        }
    }
}
