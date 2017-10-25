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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            
            InitializeComponent();
                       
        }

        private void muestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMuestra().ShowDialog(this);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Globals.idUsuario == 0)
            {
                new FrmLogin().ShowDialog(this);
            }
            this.cargarUsuario();
        }

        private void cargarUsuario()
        {
            this.toolStripStatusLabel1.Text = "Usuario: " + Globals.usuario;
        }

        private void analisisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmAnalisis().ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPaciente().ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vistas.Movimientos.FrmAnalisis().ShowDialog();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Vistas.Movimientos.FrmIngresoResultado().ShowDialog();
        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Vistas.Movimientos.FrmNuevoAnalisis().ShowDialog();   
        }
    }
}
