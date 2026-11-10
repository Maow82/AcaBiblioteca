namespace AcaBiblioteca
{
    partial class frmReportes
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
            pnlSuperiorReport = new Panel();
            pnlSuperiorReport2 = new Panel();
            lblGestionReportes = new Label();
            cmbTipoReporte = new ComboBox();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            pnlDatosReporte = new Panel();
            lblTipoReporte = new Label();
            dgvReportes = new DataGridView();
            pnlSuperiorReport2.SuspendLayout();
            pnlDatosReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperiorReport
            // 
            pnlSuperiorReport.BackColor = SystemColors.MenuHighlight;
            pnlSuperiorReport.Dock = DockStyle.Top;
            pnlSuperiorReport.Location = new Point(0, 0);
            pnlSuperiorReport.Name = "pnlSuperiorReport";
            pnlSuperiorReport.Size = new Size(1384, 50);
            pnlSuperiorReport.TabIndex = 0;
            // 
            // pnlSuperiorReport2
            // 
            pnlSuperiorReport2.BackColor = SystemColors.InactiveCaption;
            pnlSuperiorReport2.Controls.Add(lblGestionReportes);
            pnlSuperiorReport2.Dock = DockStyle.Top;
            pnlSuperiorReport2.Location = new Point(0, 50);
            pnlSuperiorReport2.Name = "pnlSuperiorReport2";
            pnlSuperiorReport2.Size = new Size(1384, 55);
            pnlSuperiorReport2.TabIndex = 1;
            // 
            // lblGestionReportes
            // 
            lblGestionReportes.AutoSize = true;
            lblGestionReportes.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionReportes.ForeColor = SystemColors.HotTrack;
            lblGestionReportes.Location = new Point(554, 15);
            lblGestionReportes.Name = "lblGestionReportes";
            lblGestionReportes.Size = new Size(245, 25);
            lblGestionReportes.TabIndex = 0;
            lblGestionReportes.Text = "GESTIÓN REPORTES";
            lblGestionReportes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(457, 95);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(200, 23);
            cmbTipoReporte.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(457, 152);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(200, 25);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar:";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(720, 152);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 25);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar:";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pnlDatosReporte
            // 
            pnlDatosReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatosReporte.Controls.Add(lblTipoReporte);
            pnlDatosReporte.Controls.Add(btnGenerar);
            pnlDatosReporte.Controls.Add(cmbTipoReporte);
            pnlDatosReporte.Controls.Add(btnLimpiar);
            pnlDatosReporte.Location = new Point(0, 111);
            pnlDatosReporte.Name = "pnlDatosReporte";
            pnlDatosReporte.Size = new Size(1384, 237);
            pnlDatosReporte.TabIndex = 5;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(457, 73);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(139, 19);
            lblTipoReporte.TabIndex = 5;
            lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = SystemColors.Menu;
            dgvReportes.BorderStyle = BorderStyle.Fixed3D;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(0, 354);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1384, 306);
            dgvReportes.TabIndex = 6;
            dgvReportes.CellDoubleClick += dgvReportes_CellDoubleClick;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 734);
            Controls.Add(dgvReportes);
            Controls.Add(pnlDatosReporte);
            Controls.Add(pnlSuperiorReport2);
            Controls.Add(pnlSuperiorReport);
            Name = "frmReportes";
            Text = "frmReportes";
            pnlSuperiorReport2.ResumeLayout(false);
            pnlSuperiorReport2.PerformLayout();
            pnlDatosReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperiorReport;
        private Panel pnlSuperiorReport2;
        private Label lblGestionReportes;
        private ComboBox cmbTipoReporte;
        private Button btnGenerar;
        private Button btnLimpiar;
        private Panel pnlDatosReporte;
        private Label lblTipoReporte;
        private DataGridView dgvReportes;
    }
}