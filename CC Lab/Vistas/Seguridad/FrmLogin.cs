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
    public partial class FrmLogin : Form
    {
        private Seguridad clsSeguridad = new Seguridad();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable result = new DataTable();
                result = clsSeguridad.login(this.txtUsuario.Text.Trim(),this.txtPassword.Text.Trim());
                if (result.Rows.Count > 0)
                {
                    Globals.usuario = result.Rows[0]["USUARIO"].ToString();
                    Globals.idUsuario = Convert.ToInt32(result.Rows[0]["IDUSUARIO"].ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en Usuario y contraseña...");
                    this.txtUsuario.Select();
                    this.txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
       
        private void FrmLogin_FormClosing(Object sender, FormClosingEventArgs e) 
        {
            if (Globals.idUsuario == 0)
                Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Select();
            this.txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
