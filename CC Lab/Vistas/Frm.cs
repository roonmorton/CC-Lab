using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab.Vistas
{
    public partial class Frm : Form
    {
        private string idMuestraTipoAnalisis = "0";
        public Frm(string idMuestraTipoAnalisis)
        {
            InitializeComponent();
            this.idMuestraTipoAnalisis = idMuestraTipoAnalisis;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new Reportes.Reportes().obtenerResultado(this.idMuestraTipoAnalisis);
        }
    }
}
