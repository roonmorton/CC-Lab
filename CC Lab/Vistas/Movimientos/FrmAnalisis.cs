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
    public partial class FrmAnalisis : Form
    {
        private Analisis clsAnalisis = new Analisis();

        public FrmAnalisis()
        {
            InitializeComponent();
        }


        private void buscar()
        {
            try
            {
                DataTable res = this.clsAnalisis.buscarAnalisis(this.txtNombres.Text.Trim());
                this.grdExistentes.DataSource = res;
                this.lblExistentes.Text = res.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmAnalisis_Load(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
            this.txtNombres.Clear();
            this.txtNombres.Focus();
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        new FrmIngresoResultado(grdExistentes.SelectedRows[0].Cells["idAnalisisCol"].Value.ToString()).ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //ClsHelper.erroLog(ex);
            }
        
        }
    }
}
