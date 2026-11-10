namespace AcaBiblioteca
{
    partial class frmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            textBuscarISBN = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtAño = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAño = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            pnlBotones = new Label();
            lblTituloLib = new Label();
            lblISBN = new Label();
            pnlBotonesAbajo = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotonesAbajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.InactiveCaption;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(6);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(561, 19);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(246, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.MintCream;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(textBuscarISBN);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(832, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBuscarISBN
            // 
            textBuscarISBN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscarISBN.Location = new Point(594, 10);
            textBuscarISBN.Name = "textBuscarISBN";
            textBuscarISBN.Size = new Size(213, 29);
            textBuscarISBN.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(493, 13);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(50, 18);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAño);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(pnlBotones);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 333);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(594, 147);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(213, 29);
            cmbEditorial.TabIndex = 16;
            // 
            // cmbAutor
            // 
            cmbAutor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(594, 101);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(213, 29);
            cmbAutor.TabIndex = 15;
            // 
            // txtExistencias
            // 
            txtExistencias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExistencias.Location = new Point(594, 280);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(213, 29);
            txtExistencias.TabIndex = 14;
            // 
            // txtAño
            // 
            txtAño.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAño.Location = new Point(594, 235);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(213, 29);
            txtAño.TabIndex = 13;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(594, 190);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(213, 29);
            txtCategoria.TabIndex = 12;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(594, 55);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(213, 29);
            txtTitulo.TabIndex = 9;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(594, 10);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(213, 29);
            txtISBN.TabIndex = 8;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(486, 294);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(109, 18);
            lblExistencias.TabIndex = 7;
            lblExistencias.Text = "Existencias:";
            lblExistencias.Click += label1_Click;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(492, 249);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(47, 18);
            lblAño.TabIndex = 6;
            lblAño.Text = "Año:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(486, 204);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(94, 18);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(486, 159);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(89, 18);
            lblEditorial.TabIndex = 4;
            lblEditorial.Text = "Editorial:";
            // 
            // pnlBotones
            // 
            pnlBotones.AutoSize = true;
            pnlBotones.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlBotones.Location = new Point(486, 109);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(62, 18);
            pnlBotones.TabIndex = 3;
            pnlBotones.Text = "Autor:";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(486, 69);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(66, 18);
            lblTituloLib.TabIndex = 2;
            lblTituloLib.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(486, 24);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(56, 18);
            lblISBN.TabIndex = 1;
            lblISBN.Text = "ISBN:";
            // 
            // pnlBotonesAbajo
            // 
            pnlBotonesAbajo.Controls.Add(btnCancelar);
            pnlBotonesAbajo.Controls.Add(btnEliminar);
            pnlBotonesAbajo.Controls.Add(btnEditar);
            pnlBotonesAbajo.Controls.Add(btnGuardar);
            pnlBotonesAbajo.Controls.Add(btnNuevo);
            pnlBotonesAbajo.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlBotonesAbajo.Location = new Point(313, 463);
            pnlBotonesAbajo.Name = "pnlBotonesAbajo";
            pnlBotonesAbajo.Size = new Size(845, 76);
            pnlBotonesAbajo.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 40;
            btnCancelar.Location = new Point(666, 24);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 45);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 40;
            btnEliminar.Location = new Point(500, 24);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 40;
            btnEditar.Location = new Point(334, 24);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 40;
            btnGuardar.Location = new Point(171, 24);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 45);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 40;
            btnNuevo.Location = new Point(5, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(160, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(277, 545);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.Size = new Size(911, 172);
            dgvLibros.TabIndex = 4;
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotonesAbajo);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "frmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLibros";
            WindowState = FormWindowState.Maximized;
            Load += frmLibros_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotonesAbajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private TextBox textBuscarISBN;
        private Label lblBuscar;
        private Button btnBuscar;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblTituloLib;
        private Label lblAño;
        private Label lblCategoria;
        private Label lblEditorial;
        private Label pnlBotones;
        private Label lblExistencias;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private TextBox txtCategoria;
        private TextBox txtAño;
        private TextBox txtExistencias;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private Panel pnlBotonesAbajo;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgvLibros;
    }
}