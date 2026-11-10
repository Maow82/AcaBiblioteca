namespace AcaBiblioteca
{
    partial class frmAutores
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
            pnlSuperiorAutor = new Panel();
            pnlSuperiorAutor2 = new Panel();
            lblGestionAutor = new Label();
            pnlDatosAutor = new Panel();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            dgvAutores = new DataGridView();
            pnlSuperiorAutor2.SuspendLayout();
            pnlDatosAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperiorAutor
            // 
            pnlSuperiorAutor.BackColor = SystemColors.MenuHighlight;
            pnlSuperiorAutor.Dock = DockStyle.Top;
            pnlSuperiorAutor.Location = new Point(0, 0);
            pnlSuperiorAutor.Name = "pnlSuperiorAutor";
            pnlSuperiorAutor.Size = new Size(1416, 50);
            pnlSuperiorAutor.TabIndex = 0;
            // 
            // pnlSuperiorAutor2
            // 
            pnlSuperiorAutor2.BackColor = SystemColors.InactiveCaption;
            pnlSuperiorAutor2.Controls.Add(lblGestionAutor);
            pnlSuperiorAutor2.Dock = DockStyle.Top;
            pnlSuperiorAutor2.Location = new Point(0, 50);
            pnlSuperiorAutor2.Name = "pnlSuperiorAutor2";
            pnlSuperiorAutor2.Size = new Size(1416, 55);
            pnlSuperiorAutor2.TabIndex = 1;
            // 
            // lblGestionAutor
            // 
            lblGestionAutor.AutoSize = true;
            lblGestionAutor.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionAutor.ForeColor = SystemColors.HotTrack;
            lblGestionAutor.Location = new Point(552, 16);
            lblGestionAutor.Name = "lblGestionAutor";
            lblGestionAutor.Size = new Size(270, 25);
            lblGestionAutor.TabIndex = 0;
            lblGestionAutor.Text = "GESTIÓN DE AUTORES";
            // 
            // pnlDatosAutor
            // 
            pnlDatosAutor.Controls.Add(btnCancelar);
            pnlDatosAutor.Controls.Add(btnEliminar);
            pnlDatosAutor.Controls.Add(btnEditar);
            pnlDatosAutor.Controls.Add(btnGuardar);
            pnlDatosAutor.Controls.Add(btnNuevo);
            pnlDatosAutor.Controls.Add(txtApellido);
            pnlDatosAutor.Controls.Add(txtNombre);
            pnlDatosAutor.Controls.Add(lblApellido);
            pnlDatosAutor.Controls.Add(lblNombre);
            pnlDatosAutor.Location = new Point(0, 111);
            pnlDatosAutor.Name = "pnlDatosAutor";
            pnlDatosAutor.Size = new Size(1412, 260);
            pnlDatosAutor.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(852, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar:";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(755, 208);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar:";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(657, 208);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar:";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(552, 208);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar: ";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(447, 208);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo:";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(589, 134);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(589, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(476, 134);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(85, 18);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(481, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // dgvAutores
            // 
            dgvAutores.AllowUserToAddRows = false;
            dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(30, 377);
            dgvAutores.MultiSelect = false;
            dgvAutores.Name = "dgvAutores";
            dgvAutores.ReadOnly = true;
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutores.Size = new Size(1356, 254);
            dgvAutores.TabIndex = 3;
            dgvAutores.CellDoubleClick += dgvAutores_CellDoubleClick;
            // 
            // frmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 659);
            Controls.Add(dgvAutores);
            Controls.Add(pnlDatosAutor);
            Controls.Add(pnlSuperiorAutor2);
            Controls.Add(pnlSuperiorAutor);
            Name = "frmAutores";
            Text = "frmAutores";
            pnlSuperiorAutor2.ResumeLayout(false);
            pnlSuperiorAutor2.PerformLayout();
            pnlDatosAutor.ResumeLayout(false);
            pnlDatosAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperiorAutor;
        private Panel pnlSuperiorAutor2;
        private Label lblGestionAutor;
        private Panel pnlDatosAutor;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvAutores;
    }
}