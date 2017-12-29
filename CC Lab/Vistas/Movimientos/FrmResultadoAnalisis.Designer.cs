namespace CC_Lab.Vistas.Movimientos
{
    partial class FrmResultadoAnalisis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultadoAnalisis));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imprimirCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.idMuestraTipoAnalisisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmuestra_tipo_analisisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(809, 34);
            this.lblTitulo.TabIndex = 53;
            this.lblTitulo.Text = "Analisis";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdExistentes
            // 
            this.grdExistentes.AllowUserToAddRows = false;
            this.grdExistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdExistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExistentes.BackgroundColor = System.Drawing.Color.White;
            this.grdExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdExistentes.ColumnHeadersHeight = 30;
            this.grdExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imprimirCol,
            this.idMuestraTipoAnalisisCol,
            this.idmuestra_tipo_analisisCol});
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(3, 58);
            this.grdExistentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.ReadOnly = true;
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdExistentes.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdExistentes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdExistentes.RowTemplate.Height = 30;
            this.grdExistentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExistentes.Size = new System.Drawing.Size(806, 273);
            this.grdExistentes.TabIndex = 95;
            this.grdExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExistentes_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.FillWeight = 78.99126F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CC_Lab.Properties.Resources.Print_24px;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // imprimirCol
            // 
            this.imprimirCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.imprimirCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.imprimirCol.FillWeight = 78.99126F;
            this.imprimirCol.HeaderText = "";
            this.imprimirCol.Image = global::CC_Lab.Properties.Resources.Print_24px;
            this.imprimirCol.MinimumWidth = 50;
            this.imprimirCol.Name = "imprimirCol";
            this.imprimirCol.ReadOnly = true;
            this.imprimirCol.Width = 50;
            // 
            // idMuestraTipoAnalisisCol
            // 
            this.idMuestraTipoAnalisisCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idMuestraTipoAnalisisCol.DataPropertyName = "idMuestraTipoAnalisis";
            this.idMuestraTipoAnalisisCol.HeaderText = "CODIGO";
            this.idMuestraTipoAnalisisCol.MinimumWidth = 60;
            this.idMuestraTipoAnalisisCol.Name = "idMuestraTipoAnalisisCol";
            this.idMuestraTipoAnalisisCol.ReadOnly = true;
            this.idMuestraTipoAnalisisCol.Visible = false;
            this.idMuestraTipoAnalisisCol.Width = 60;
            // 
            // idmuestra_tipo_analisisCol
            // 
            this.idmuestra_tipo_analisisCol.DataPropertyName = "idmuestra_tipo_analisis";
            this.idmuestra_tipo_analisisCol.HeaderText = "TIPO ANALISIS";
            this.idmuestra_tipo_analisisCol.Name = "idmuestra_tipo_analisisCol";
            this.idmuestra_tipo_analisisCol.ReadOnly = true;
            // 
            // FrmResultadoAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 333);
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmResultadoAnalisis";
            this.Text = "FrmResultadoAnalisis";
            this.Load += new System.EventHandler(this.FrmResultadoAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imprimirCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMuestraTipoAnalisisCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmuestra_tipo_analisisCol;
    }
}