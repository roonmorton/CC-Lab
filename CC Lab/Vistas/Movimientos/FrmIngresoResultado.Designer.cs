namespace CC_Lab.Vistas.Movimientos
{
    partial class FrmIngresoResultado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaAnalisis = new System.Windows.Forms.MaskedTextBox();
            this.tipo_AnalisisCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_resultadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMedidaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorNormalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idResultadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vResultadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMuestra = new System.Windows.Forms.TextBox();
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
            this.lblTitulo.Size = new System.Drawing.Size(1064, 34);
            this.lblTitulo.TabIndex = 53;
            this.lblTitulo.Text = "Resultados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(921, 84);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 23);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(67, 43);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(380, 20);
            this.txtPaciente.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Paciente";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(921, 43);
            this.txtFecha.Mask = "00/00/0000 00:00";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(122, 20);
            this.txtFecha.TabIndex = 61;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(67, 69);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(94, 20);
            this.txtEdad.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Edad";
            // 
            // grdExistentes
            // 
            this.grdExistentes.AllowUserToAddRows = false;
            this.grdExistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdExistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExistentes.BackgroundColor = System.Drawing.Color.White;
            this.grdExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdExistentes.ColumnHeadersHeight = 30;
            this.grdExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_AnalisisCol,
            this.tipo_resultadoCol,
            this.resultadoCol,
            this.TipoMedidaCol,
            this.ValorNormalCol,
            this.idResultadoCol,
            this.vResultadoCol});
            this.grdExistentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(15, 122);
            this.grdExistentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdExistentes.RowHeadersWidth = 20;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdExistentes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdExistentes.RowTemplate.Height = 30;
            this.grdExistentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExistentes.Size = new System.Drawing.Size(1037, 406);
            this.grdExistentes.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha analisis";
            // 
            // txtFechaAnalisis
            // 
            this.txtFechaAnalisis.Enabled = false;
            this.txtFechaAnalisis.Location = new System.Drawing.Point(283, 73);
            this.txtFechaAnalisis.Mask = "00/00/0000 00:00";
            this.txtFechaAnalisis.Name = "txtFechaAnalisis";
            this.txtFechaAnalisis.Size = new System.Drawing.Size(164, 20);
            this.txtFechaAnalisis.TabIndex = 66;
            this.txtFechaAnalisis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaAnalisis.ValidatingType = typeof(System.DateTime);
            // 
            // tipo_AnalisisCol
            // 
            this.tipo_AnalisisCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipo_AnalisisCol.DataPropertyName = "tipo_Analisis";
            this.tipo_AnalisisCol.HeaderText = "TIPO ANALISIS";
            this.tipo_AnalisisCol.MinimumWidth = 190;
            this.tipo_AnalisisCol.Name = "tipo_AnalisisCol";
            this.tipo_AnalisisCol.Width = 190;
            // 
            // tipo_resultadoCol
            // 
            this.tipo_resultadoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipo_resultadoCol.DataPropertyName = "tipo_resultado";
            this.tipo_resultadoCol.HeaderText = "TIPO_RESULTADO";
            this.tipo_resultadoCol.MinimumWidth = 190;
            this.tipo_resultadoCol.Name = "tipo_resultadoCol";
            this.tipo_resultadoCol.Width = 190;
            // 
            // resultadoCol
            // 
            this.resultadoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.resultadoCol.DataPropertyName = "resultado";
            this.resultadoCol.HeaderText = "RESULTADO";
            this.resultadoCol.MinimumWidth = 130;
            this.resultadoCol.Name = "resultadoCol";
            this.resultadoCol.Width = 130;
            // 
            // TipoMedidaCol
            // 
            this.TipoMedidaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoMedidaCol.DataPropertyName = "TipoMedida";
            this.TipoMedidaCol.HeaderText = "TIPO MEDIDA";
            this.TipoMedidaCol.MinimumWidth = 80;
            this.TipoMedidaCol.Name = "TipoMedidaCol";
            // 
            // ValorNormalCol
            // 
            this.ValorNormalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorNormalCol.DataPropertyName = "ValorNormal";
            this.ValorNormalCol.HeaderText = "VALOR NORMAL";
            this.ValorNormalCol.MinimumWidth = 110;
            this.ValorNormalCol.Name = "ValorNormalCol";
            this.ValorNormalCol.Width = 110;
            // 
            // idResultadoCol
            // 
            this.idResultadoCol.DataPropertyName = "idResultado";
            this.idResultadoCol.HeaderText = "ID RESULTADO";
            this.idResultadoCol.Name = "idResultadoCol";
            this.idResultadoCol.Visible = false;
            // 
            // vResultadoCol
            // 
            this.vResultadoCol.DataPropertyName = "vResultado";
            this.vResultadoCol.HeaderText = "V. Resultado";
            this.vResultadoCol.Name = "vResultadoCol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tipo Analisis";
            // 
            // txtMuestra
            // 
            this.txtMuestra.Enabled = false;
            this.txtMuestra.Location = new System.Drawing.Point(522, 73);
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(323, 20);
            this.txtMuestra.TabIndex = 68;
            // 
            // FrmIngresoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1064, 541);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaAnalisis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmIngresoResultado";
            this.Text = "FrmIngresoResultado";
            this.Load += new System.EventHandler(this.FrmIngresoResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFechaAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_AnalisisCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_resultadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMedidaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorNormalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResultadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vResultadoCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMuestra;
    }
}