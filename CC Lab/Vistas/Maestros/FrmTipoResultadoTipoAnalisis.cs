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
    public partial class FrmTipoResultadoTipoAnalisis : Form
    {
        private string idMuestra = "0", idTipoAnalisis = "0", idMuestraTipoAnalisis = "0",titulo;
        private Analisis clsAnalisis = new Analisis();

        public FrmTipoResultadoTipoAnalisis(string idMuestra, string idTipoAnalisis, string titulo, string idMuestraTipoAnalisis)
        {
            InitializeComponent();
            this.idMuestra = idMuestra;
            this.idTipoAnalisis = idTipoAnalisis;
            this.lblTitulo.Text = titulo;
            this.idMuestraTipoAnalisis = idMuestraTipoAnalisis;
            this.titulo = titulo;
           // MessageBox.Show("id Muestra tipo analisis: " + this.idMuestra_tipo_analisis);
        }


        private void cargarGrid()
        {
            try
            {
                this.grdExistentes.DataSource = this.clsAnalisis.selecttipoResultadoTipoAnalisis(this.idMuestraTipoAnalisis);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmMuestraTipoResultado_Load(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //int idMuestra = Convert.ToInt32(cmbMuestra.SelectedValue); // idMuestra_tipo_analisis
            string idTipoResultado;
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
                    idTipoResultado = r.Cells["idTipo_resultadoCol"].Value.ToString();

                    //idTipoAnalisis = Convert.ToInt32(r.Cells["idTipo_analisisCol"].Value.ToString());
                    //MessageBox.Show("llego");
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString()) ? "0" : r.Cells["accesoCol"].Value.ToString());
                    //MessageBox.Show("acceso: " + acceso.ToString() + "id " + idTipoAnalisis.ToString());
                   // clsAnalisis.brindarDenegarAccesoTipoAnalisisMuestra(idMuestra, idTipoAnalisis, acceso);
                    clsAnalisis.brindarDenegarAccesoTipoResultadoTipoAnalisis(this.idMuestraTipoAnalisis, idTipoResultado, acceso);
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
                MessageBox.Show("Error 1: " + ex.Message);
                this.cargarGrid();
            }
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        int acceso = Convert.ToInt32(string.IsNullOrEmpty(grdExistentes.SelectedRows[0].Cells["accesoCol"].Value.ToString()) ? "0" : grdExistentes.SelectedRows[0].Cells["accesoCol"].Value.ToString());
                        if (acceso == 1)
                        {
                            /*string idTipoAnalisis = grdExistentes.SelectedRows[0].Cells["idTipo_AnalisisCol"].Value.ToString();
                            int idMuestra = Convert.ToInt32(cmbMuestra.SelectedValue);*/
                            //Se mandara nombreMuestra,idMuestra,nombre tipoAnalisis, idTipo Analisis

                            /*string _nombreMuestra = cmbMuestra.Text;
                            string _idMuestra = cmbMuestra.SelectedValue.ToString();
                            string _tipoAnalisis = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                            string _idtipoAnalisis = grdExistentes.SelectedRows[0].Cells["idTipo_analisisCol"].Value.ToString();
                            string _idMuestra_tipo_analisis = grdExistentes.SelectedRows[0].Cells["idMuestra_tipo_analisisCol"].Value.ToString();*/
                            string _IdMuestra_Tipo_Analisis = grdExistentes.SelectedRows[0].Cells["IdMuestra_Tipo_AnalisisCol"].Value.ToString();
                           
 

                            //mODIFICAR
                            string _IDMUESTRA_TIPO_ANALISIS_RESULTADO = grdExistentes.SelectedRows[0].Cells["IDMUESTRA_TIPO_ANALISIS_RESULTADOCol"].Value.ToString(); ;

                            if (_IdMuestra_Tipo_Analisis != "")
                            {
                                string _idTipoResultado = grdExistentes.SelectedRows[0].Cells["idTipo_resultadoCol"].Value.ToString();
                                string _titulo = this.titulo + " > " + grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();

                                new FrmResultadoTipoResultado(_IDMUESTRA_TIPO_ANALISIS_RESULTADO,_titulo ).ShowDialog();
                                //new FrmMuestraTipoResultado(_idMuestra, _idtipoAnalisis, _nombreMuestra + " > " + _tipoAnalisis, _idMuestra_tipo_analisis).ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("No se ha guardado la asignacion, guardar y continuar");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tipo de resultado no asignado");
                        }


                        //idMuestra = grdExistentes.SelectedRows[0].Cells["idMuestraCol"].Value.ToString();
                        //txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString();
                        //txtDescripcion.Enabled = true;
                        //txtDescripcion.Focus();
                        //MessageBox.Show("Config");


                        // mandar a llanmae formulario para asignar los tipos de resultado

                        //MessageBox.Show("muestra: " + _nombreMuestra + "idMestra: " + _idMuestra + "tipoAnalisis: " + _tipoAnalisis + "idTipoAnalisis: "+ _idtipoAnalisis);
                        break;
                    /*case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsMuestra.eliminar(grdExistentes.SelectedRows[0].Cells["idMuestraCol"].Value.ToString());
                            MessageBox.Show("Registro Eliminado");
                            limpiarControles();
                        }
                        break;*/
                }
            }
            catch (Exception ex)
            {
                //idMuestra = "0";
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmTipoResultado().ShowDialog();
            this.cargarGrid();
        }



        
    }
}
