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
    public partial class FrmResultado : Form
    {

        private Resultado clsResultado = new Resultado();
        private string idResultado = "0";


        public FrmResultado()
        {
            InitializeComponent();
        }


        private void buscar()
        {
            try
            {
                DataTable res = this.clsResultado.seleccionar(this.txtDescripcion.Text.Trim());
                this.grdExistentes.DataSource = res;
                this.lblExistentes.Text = res.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void limpiarControles()
        {
            this.idResultado = "0";
            this.txtDescripcion.Clear();
            this.txtTipoMedida.Clear();
            this.txtValorNormal.Clear();
            this.buscar();
            this.txtDescripcion.Focus();
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.idResultado = grdExistentes.SelectedRows[0].Cells["idResultadoCol"].Value.ToString();
                        this.txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                        this.txtTipoMedida.Text = grdExistentes.SelectedRows[0].Cells["tipoMedidaCol"].Value.ToString();

                        this.txtValorNormal.Text = grdExistentes.SelectedRows[0].Cells["valorCol"].Value.ToString();
                        //this.idTipoResultado = grdExistentes.SelectedRows[0].Cells["idTipo_resultadoCol"].Value.ToString();
                        //this.txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                        this.txtDescripcion.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsResultado.eliminar(grdExistentes.SelectedRows[0].Cells["idResultadoCol"].Value.ToString());
                            //this.clsTipoResultado.eliminar(grdExistentes.SelectedRows[0].Cells["idTipo_resultadoCol"].Value.ToString());
                            MessageBox.Show("Registro Eliminado");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.idResultado = "0";
                MessageBox.Show("Ha ocurrido un error:e " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDescripcion.Text != "")
                {
                    this.clsResultado.grabarModificar(this.idResultado, this.txtDescripcion.Text.Trim(), this.txtValorNormal.Text.Trim(), this.txtTipoMedida.Text.Trim());
                    MessageBox.Show("Guardado correctamente...");
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("El resultado debe contener una Descripcion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
