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
        private string idAnalisis = "0";
        private Analisis clsAnalsis = new Analisis();

        public FrmIngresoResultado(string idAnalisis)
        {
            InitializeComponent();
            this.idAnalisis = idAnalisis;
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

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
