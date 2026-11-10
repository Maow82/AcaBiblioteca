namespace AcaBiblioteca
{
    partial class frmPrestamos
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
            pnlSuperiorPrest = new Panel();
            pnlSuperiorPrest2 = new Panel();
            lblGestionPrestamo = new Label();
            pnlDatosPrest = new Panel();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaDevolucion = new Label();
            lblFechaPrestamo = new Label();
            cmbLibro = new ComboBox();
            lblLibro = new Label();
            cmbUsuario = new ComboBox();
            lblUsuario = new Label();
            dgvPrestamos = new DataGridView();
            pnlSuperiorPrest2.SuspendLayout();
            pnlDatosPrest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperiorPrest
            // 
            pnlSuperiorPrest.BackColor = SystemColors.MenuHighlight;
            pnlSuperiorPrest.Dock = DockStyle.Top;
            pnlSuperiorPrest.Location = new Point(0, 0);
            pnlSuperiorPrest.Name = "pnlSuperiorPrest";
            pnlSuperiorPrest.Size = new Size(1385, 50);
            pnlSuperiorPrest.TabIndex = 0;
            // 
            // pnlSuperiorPrest2
            // 
            pnlSuperiorPrest2.BackColor = SystemColors.InactiveCaption;
            pnlSuperiorPrest2.Controls.Add(lblGestionPrestamo);
            pnlSuperiorPrest2.Dock = DockStyle.Top;
            pnlSuperiorPrest2.Location = new Point(0, 50);
            pnlSuperiorPrest2.Name = "pnlSuperiorPrest2";
            pnlSuperiorPrest2.Size = new Size(1385, 55);
            pnlSuperiorPrest2.TabIndex = 1;
            // 
            // lblGestionPrestamo
            // 
            lblGestionPrestamo.AutoSize = true;
            lblGestionPrestamo.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionPrestamo.ForeColor = SystemColors.HotTrack;
            lblGestionPrestamo.Location = new Point(534, 17);
            lblGestionPrestamo.Name = "lblGestionPrestamo";
            lblGestionPrestamo.Size = new Size(308, 25);
            lblGestionPrestamo.TabIndex = 0;
            lblGestionPrestamo.Text = "GESTIÓN DE PRESTAMOS ";
            // 
            // pnlDatosPrest
            // 
            pnlDatosPrest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatosPrest.Controls.Add(btnCancelar);
            pnlDatosPrest.Controls.Add(btnEliminar);
            pnlDatosPrest.Controls.Add(btnEditar);
            pnlDatosPrest.Controls.Add(btnGuardar);
            pnlDatosPrest.Controls.Add(btnNuevo);
            pnlDatosPrest.Controls.Add(dtpFechaDevolucion);
            pnlDatosPrest.Controls.Add(dtpFechaPrestamo);
            pnlDatosPrest.Controls.Add(lblFechaDevolucion);
            pnlDatosPrest.Controls.Add(lblFechaPrestamo);
            pnlDatosPrest.Controls.Add(cmbLibro);
            pnlDatosPrest.Controls.Add(lblLibro);
            pnlDatosPrest.Controls.Add(cmbUsuario);
            pnlDatosPrest.Controls.Add(lblUsuario);
            pnlDatosPrest.Location = new Point(0, 111);
            pnlDatosPrest.Name = "pnlDatosPrest";
            pnlDatosPrest.Size = new Size(1385, 256);
            pnlDatosPrest.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(874, 175);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar:";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(768, 175);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar:";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(659, 175);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 30);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar:";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(547, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar:";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(442, 175);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 30);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo:";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Checked = false;
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(911, 91);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Size = new Size(200, 23);
            dtpFechaDevolucion.TabIndex = 7;
            dtpFechaDevolucion.Value = new DateTime(2026, 11, 6, 13, 35, 59, 0);
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(911, 38);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(200, 23);
            dtpFechaPrestamo.TabIndex = 6;
            dtpFechaPrestamo.Value = new DateTime(2026, 11, 6, 13, 35, 59, 0);
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaDevolucion.Location = new Point(742, 98);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(121, 16);
            lblFechaDevolucion.TabIndex = 5;
            lblFechaDevolucion.Text = "Fecha devolución:";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaPrestamo.Location = new Point(742, 43);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(113, 16);
            lblFechaPrestamo.TabIndex = 4;
            lblFechaPrestamo.Text = "Fecha  Préstamo:";
            // 
            // cmbLibro
            // 
            cmbLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(395, 96);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(200, 23);
            cmbLibro.TabIndex = 3;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(329, 98);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(45, 16);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(395, 43);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(200, 23);
            cmbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(329, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 16);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = SystemColors.Menu;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(0, 373);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1385, 312);
            dgvPrestamos.TabIndex = 3;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 717);
            Controls.Add(dgvPrestamos);
            Controls.Add(pnlDatosPrest);
            Controls.Add(pnlSuperiorPrest2);
            Controls.Add(pnlSuperiorPrest);
            Name = "frmPrestamos";
            Text = "frmPrestamos";
            pnlSuperiorPrest2.ResumeLayout(false);
            pnlSuperiorPrest2.PerformLayout();
            pnlDatosPrest.ResumeLayout(false);
            pnlDatosPrest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperiorPrest;
        private Panel pnlSuperiorPrest2;
        private Label lblGestionPrestamo;
        private Panel pnlDatosPrest;
        private ComboBox cmbUsuario;
        private Label lblUsuario;
        private ComboBox cmbLibro;
        private Label lblLibro;
        private Label lblFechaDevolucion;
        private Label lblFechaPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvPrestamos;
    }
}