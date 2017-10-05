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
            this.lblUsuario = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hefgegegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes,
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            resources.ApplyResources(this.lblExistentes, "lblExistentes");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestrasToolStripMenuItem,
            this.analisisToolStripMenuItem1});
            this.pacientesToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Health_Book_24px;
            resources.ApplyResources(this.pacientesToolStripMenuItem, "pacientesToolStripMenuItem");
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Color_Dropper_24px;
            resources.ApplyResources(this.muestrasToolStripMenuItem, "muestrasToolStripMenuItem");
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Click += new System.EventHandler(this.muestrasToolStripMenuItem_Click);
            // 
            // analisisToolStripMenuItem1
            // 
            this.analisisToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoAnalisisToolStripMenuItem,
            this.tipoResultadoToolStripMenuItem,
            this.resultadosToolStripMenuItem});
            this.analisisToolStripMenuItem1.Image = global::CC_Lab.Properties.Resources.Survey_24px;
            resources.ApplyResources(this.analisisToolStripMenuItem1, "analisisToolStripMenuItem1");
            this.analisisToolStripMenuItem1.Name = "analisisToolStripMenuItem1";
            // 
            // tipoAnalisisToolStripMenuItem
            // 
            this.tipoAnalisisToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Analyze_24px;
            resources.ApplyResources(this.tipoAnalisisToolStripMenuItem, "tipoAnalisisToolStripMenuItem");
            this.tipoAnalisisToolStripMenuItem.Name = "tipoAnalisisToolStripMenuItem";
            // 
            // tipoResultadoToolStripMenuItem
            // 
            this.tipoResultadoToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Elections_24px;
            resources.ApplyResources(this.tipoResultadoToolStripMenuItem, "tipoResultadoToolStripMenuItem");
            this.tipoResultadoToolStripMenuItem.Name = "tipoResultadoToolStripMenuItem";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Report_Card_24px;
            resources.ApplyResources(this.resultadosToolStripMenuItem, "resultadosToolStripMenuItem");
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.analisisToolStripMenuItem});
            this.movimientosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Move_Node_Down_24px;
            resources.ApplyResources(this.movimientosToolStripMenuItem, "movimientosToolStripMenuItem");
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Recovery_24px;
            resources.ApplyResources(this.pacienteToolStripMenuItem, "pacienteToolStripMenuItem");
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            // 
            // analisisToolStripMenuItem
            // 
            this.analisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.pendientesToolStripMenuItem});
            this.analisisToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Infusion_Pumps_24px;
            resources.ApplyResources(this.analisisToolStripMenuItem, "analisisToolStripMenuItem");
            this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Treatment_Plan_24px;
            resources.ApplyResources(this.nuevoToolStripMenuItem, "nuevoToolStripMenuItem");
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Dialysis_Machine_24px;
            resources.ApplyResources(this.pendientesToolStripMenuItem, "pendientesToolStripMenuItem");
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Data_Protection_24px;
            resources.ApplyResources(this.seguridadToolStripMenuItem, "seguridadToolStripMenuItem");
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaDeBaseDeDatosToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Data_Configuration_24px1;
            resources.ApplyResources(this.baseDeDatosToolStripMenuItem, "baseDeDatosToolStripMenuItem");
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            // 
            // crearCopiaDeBaseDeDatosToolStripMenuItem
            // 
            this.crearCopiaDeBaseDeDatosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Cloud_Storage_24px;
            resources.ApplyResources(this.crearCopiaDeBaseDeDatosToolStripMenuItem, "crearCopiaDeBaseDeDatosToolStripMenuItem");
            this.crearCopiaDeBaseDeDatosToolStripMenuItem.Name = "crearCopiaDeBaseDeDatosToolStripMenuItem";
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Data_Backup_24px;
            resources.ApplyResources(this.restaurarToolStripMenuItem, "restaurarToolStripMenuItem");
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.permisosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.User_Shield_24px;
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Image = global::CC_Lab.Properties.Resources.Collaborator_Male_24px;
            resources.ApplyResources(this.usuariosToolStripMenuItem1, "usuariosToolStripMenuItem1");
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Administrative_Tools_24px;
            resources.ApplyResources(this.permisosToolStripMenuItem, "permisosToolStripMenuItem");
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Image = global::CC_Lab.Properties.Resources.Shutdown_24px;
            resources.ApplyResources(this.cerrarSesiónToolStripMenuItem, "cerrarSesiónToolStripMenuItem");
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.hefgegegToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // hefgegegToolStripMenuItem
            // 
            this.hefgegegToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.hefgegegToolStripMenuItem.Name = "hefgegegToolStripMenuItem";
            resources.ApplyResources(this.hefgegegToolStripMenuItem, "hefgegegToolStripMenuItem");
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::CC_Lab.Properties.Resources.background;
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.lblUsuario.ResumeLayout(false);
            this.lblUsuario.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hefgegegToolStripMenuItem;



    }
}