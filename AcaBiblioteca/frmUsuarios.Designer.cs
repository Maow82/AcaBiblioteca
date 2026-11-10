namespace AcaBiblioteca
{
    partial class frmUsuarios
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
            pnlSuperiorUser = new Panel();
            pnlSuperiosUser2 = new Panel();
            lblGestiosUser = new Label();
            pnlDatosUser = new Panel();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblDocumento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            dgvUsuarios = new DataGridView();
            pnlSuperiosUser2.SuspendLayout();
            pnlDatosUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperiorUser
            // 
            pnlSuperiorUser.BackColor = SystemColors.MenuHighlight;
            pnlSuperiorUser.Dock = DockStyle.Top;
            pnlSuperiorUser.Location = new Point(0, 0);
            pnlSuperiorUser.Name = "pnlSuperiorUser";
            pnlSuperiorUser.Size = new Size(1582, 50);
            pnlSuperiorUser.TabIndex = 1;
            pnlSuperiorUser.Paint += panel1_Paint;
            // 
            // pnlSuperiosUser2
            // 
            pnlSuperiosUser2.BackColor = SystemColors.InactiveCaption;
            pnlSuperiosUser2.Controls.Add(lblGestiosUser);
            pnlSuperiosUser2.Dock = DockStyle.Top;
            pnlSuperiosUser2.Location = new Point(0, 50);
            pnlSuperiosUser2.Name = "pnlSuperiosUser2";
            pnlSuperiosUser2.Size = new Size(1582, 55);
            pnlSuperiosUser2.TabIndex = 2;
            // 
            // lblGestiosUser
            // 
            lblGestiosUser.AutoSize = true;
            lblGestiosUser.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestiosUser.ForeColor = SystemColors.HotTrack;
            lblGestiosUser.Location = new Point(550, 16);
            lblGestiosUser.Name = "lblGestiosUser";
            lblGestiosUser.Size = new Size(282, 25);
            lblGestiosUser.TabIndex = 3;
            lblGestiosUser.Text = "GESTION DE USUARIOS";
            lblGestiosUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDatosUser
            // 
            pnlDatosUser.Controls.Add(btnCancelar);
            pnlDatosUser.Controls.Add(btnEliminar);
            pnlDatosUser.Controls.Add(btnEditar);
            pnlDatosUser.Controls.Add(btnGuardar);
            pnlDatosUser.Controls.Add(btnNuevo);
            pnlDatosUser.Controls.Add(txtCorreo);
            pnlDatosUser.Controls.Add(txtTelefono);
            pnlDatosUser.Controls.Add(txtDocumento);
            pnlDatosUser.Controls.Add(txtApellido);
            pnlDatosUser.Controls.Add(txtNombre);
            pnlDatosUser.Controls.Add(lblCorreo);
            pnlDatosUser.Controls.Add(lblTelefono);
            pnlDatosUser.Controls.Add(lblDocumento);
            pnlDatosUser.Controls.Add(lblApellido);
            pnlDatosUser.Controls.Add(lblNombre);
            pnlDatosUser.Location = new Point(139, 126);
            pnlDatosUser.Name = "pnlDatosUser";
            pnlDatosUser.Size = new Size(1033, 291);
            pnlDatosUser.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(723, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(593, 226);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(475, 226);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(353, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(248, 226);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(393, 144);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(300, 23);
            txtCorreo.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(393, 115);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 23);
            txtTelefono.TabIndex = 11;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(393, 86);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(300, 23);
            txtDocumento.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(393, 57);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(393, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 23);
            txtNombre.TabIndex = 8;
            // 
            // lblCorreo
            // 
            lblCorreo.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(287, 144);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(100, 23);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(287, 115);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(100, 23);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDocumento
            // 
            lblDocumento.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(287, 86);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(100, 23);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento:";
            // 
            // lblApellido
            // 
            lblApellido.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(287, 57);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(100, 23);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(287, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(21, 435);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1250, 200);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 647);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlDatosUser);
            Controls.Add(pnlSuperiosUser2);
            Controls.Add(pnlSuperiorUser);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            pnlSuperiosUser2.ResumeLayout(false);
            pnlSuperiosUser2.PerformLayout();
            pnlDatosUser.ResumeLayout(false);
            pnlDatosUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlMenuUser;
        private Panel pnlSuperiorUser;
        private Panel pnlSuperior;
        private PictureBox picLogo;
        private Panel pnlSuperiosUser2;
        private Label lblGestiosUser;
        private Panel pnlDatosUser;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblCorreo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDocumento;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvUsuarios;
    }
}