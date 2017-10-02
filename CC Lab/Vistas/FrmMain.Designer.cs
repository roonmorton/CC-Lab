namespace CC_Lab
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioContraseñaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Individual_Server_24px;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            // 
            // cambioContraseñaToolStripMenuItem
            // 
            resources.ApplyResources(this.cambioContraseñaToolStripMenuItem, "cambioContraseñaToolStripMenuItem");
            this.cambioContraseñaToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Password_24px;
            this.cambioContraseñaToolStripMenuItem.Name = "cambioContraseñaToolStripMenuItem";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            resources.ApplyResources(this.cerrarSesiónToolStripMenuItem, "cerrarSesiónToolStripMenuItem");
            this.cerrarSesiónToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Shutdown_24px;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            // 
            // pacientesToolStripMenuItem
            // 
            resources.ApplyResources(this.pacientesToolStripMenuItem, "pacientesToolStripMenuItem");
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestrasToolStripMenuItem,
            this.tiposDeAnalisisToolStripMenuItem,
            this.resultadoToolStripMenuItem});
            this.pacientesToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Health_Book_24px;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            // 
            // tiposDeAnalisisToolStripMenuItem
            // 
            resources.ApplyResources(this.tiposDeAnalisisToolStripMenuItem, "tiposDeAnalisisToolStripMenuItem");
            this.tiposDeAnalisisToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Urine_Collection_24px;
            this.tiposDeAnalisisToolStripMenuItem.Name = "tiposDeAnalisisToolStripMenuItem";
            // 
            // muestrasToolStripMenuItem
            // 
            resources.ApplyResources(this.muestrasToolStripMenuItem, "muestrasToolStripMenuItem");
            this.muestrasToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Color_Dropper_24px;
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Click += new System.EventHandler(this.muestrasToolStripMenuItem_Click);
            // 
            // resultadoToolStripMenuItem
            // 
            resources.ApplyResources(this.resultadoToolStripMenuItem, "resultadoToolStripMenuItem");
            this.resultadoToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Survey_24px;
            this.resultadoToolStripMenuItem.Name = "resultadoToolStripMenuItem";
            // 
            // movimientosToolStripMenuItem
            // 
            resources.ApplyResources(this.movimientosToolStripMenuItem, "movimientosToolStripMenuItem");
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.analisisToolStripMenuItem});
            this.movimientosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Move_Node_Down_24px;
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            // 
            // pacienteToolStripMenuItem
            // 
            resources.ApplyResources(this.pacienteToolStripMenuItem, "pacienteToolStripMenuItem");
            this.pacienteToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Recovery_24px;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            // 
            // analisisToolStripMenuItem
            // 
            resources.ApplyResources(this.analisisToolStripMenuItem, "analisisToolStripMenuItem");
            this.analisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.pendientesToolStripMenuItem});
            this.analisisToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Infusion_Pumps_24px;
            this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
            // 
            // nuevoToolStripMenuItem
            // 
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            this.nuevoToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Treatment_Plan_24px;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            // 
            // pendientesToolStripMenuItem
            // 
            resources.ApplyResources(this.pendientesToolStripMenuItem, "pendientesToolStripMenuItem");
            this.pendientesToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Dialysis_Machine_24px;
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            // 
            // seguridadToolStripMenuItem
            // 
            resources.ApplyResources(this.seguridadToolStripMenuItem, "seguridadToolStripMenuItem");
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Data_Protection_24px;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            resources.ApplyResources(this.baseDeDatosToolStripMenuItem, "baseDeDatosToolStripMenuItem");
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaDeBaseDeDatosToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Data_Configuration_24px1;
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            // 
            // crearCopiaDeBaseDeDatosToolStripMenuItem
            // 
            resources.ApplyResources(this.crearCopiaDeBaseDeDatosToolStripMenuItem, "crearCopiaDeBaseDeDatosToolStripMenuItem");
            this.crearCopiaDeBaseDeDatosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Cloud_Storage_24px;
            this.crearCopiaDeBaseDeDatosToolStripMenuItem.Name = "crearCopiaDeBaseDeDatosToolStripMenuItem";
            // 
            // restaurarToolStripMenuItem
            // 
            resources.ApplyResources(this.restaurarToolStripMenuItem, "restaurarToolStripMenuItem");
            this.restaurarToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Data_Backup_24px;
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            // 
            // usuariosToolStripMenuItem
            // 
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.permisosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.User_Shield_24px;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            // 
            // usuariosToolStripMenuItem1
            // 
            resources.ApplyResources(this.usuariosToolStripMenuItem1, "usuariosToolStripMenuItem1");
            this.usuariosToolStripMenuItem1.Image = global::CC_Lab.Properties.Resources.Collaborator_Male_24px;
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            // 
            // permisosToolStripMenuItem
            // 
            resources.ApplyResources(this.permisosToolStripMenuItem, "permisosToolStripMenuItem");
            this.permisosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Administrative_Tools_24px;
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::CC_Lab.Properties.Resources.background;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;



    }
}