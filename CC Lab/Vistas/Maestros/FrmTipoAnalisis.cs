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
    public partial class FrmTipoAnalisis : Form
    {
        TipoAnalisis clsTipoAnalisis = new TipoAnalisis();
        string idTipoAnalisis = "0";

        public FrmTipoAnalisis()
        {
            InitializeComponent();
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                clsTipoAnalisis.grabarModificar(idTipoAnalisis,txtTipoAnalisis.Text);
                MessageBox.Show("Ejecutado correctamente...");
                this.idTipoAnalisis = "0";
                this.buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buscar()
        {
            try
            {
                this.grdExistentes.DataSource = clsTipoAnalisis.seleccionar(this.txtTipoAnalisis.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmTipoAnalisis_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //0 Editar, 1 Rol
                switch (e.ColumnIndex)
                {
                    case 0:
                        idTipoAnalisis = grdExistentes.SelectedRows[0].Cells["idTipo_AnalisisCol"].Value.ToString();
                        txtTipoAnalisis.Text = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                        txtTipoAnalisis.Focus();
                       /* idUsuario = grdExistentes.SelectedRows[0].Cells["idUsuarioCol"].Value.ToString();
                        txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        txtUsuario.Text = grdExistentes.SelectedRows[0].Cells["UsuarioCol"].Value.ToString();
                        txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["observacionesCol"].Value.ToString();
                        txtFechaNacimiento.Text = grdExistentes.SelectedRows[0].Cells["fechaNacimientoCol"].Value.ToString();
                        chkActivo.Checked = grdExistentes.SelectedRows[0].Cells["activoCol"].Value.ToString() == "1" ? true : false;
                        chkReiniciarContrasena.Checked = grdExistentes.SelectedRows[0].Cells["cambiarContrasenaCol"].Value.ToString() == "1" ? true : false;*/
                        break;

                    case 1:

                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsTipoAnalisis.eliminar(grdExistentes.SelectedRows[0].Cells["idTipo_AnalisisCol"].Value.ToString());
                            MessageBox.Show("Eliminado correctamente");
                            buscar();
                        }
                        
                        /*PV.Vistas.FrmRolUsuario frm = new PV.Vistas.FrmRolUsuario();
                        frm.idUsuario = grdExistentes.SelectedRows[0].Cells["idUsuarioCol"].Value.ToString();
                        frm.usuario = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        frm.ShowDialog();*/
                        break;
                }

            }
            catch (Exception ex)
            {

                this.idTipoAnalisis = "0";
                MessageBox.Show("Error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        }
    }
}
