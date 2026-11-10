namespace AcaBiblioteca
{
    partial class frmEditoriales
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
            pnlSuperiorEdit = new Panel();
            pnlSuperiorEdit2 = new Panel();
            lblGestionEditorial = new Label();
            pnlDatosEdit = new Panel();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtNombre = new TextBox();
            lblNombreEdit = new Label();
            dgvEditoriales = new DataGridView();
            pnlSuperiorEdit2.SuspendLayout();
            pnlDatosEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperiorEdit
            // 
            pnlSuperiorEdit.BackColor = SystemColors.Highlight;
            pnlSuperiorEdit.Dock = DockStyle.Top;
            pnlSuperiorEdit.Location = new Point(0, 0);
            pnlSuperiorEdit.Name = "pnlSuperiorEdit";
            pnlSuperiorEdit.Size = new Size(1628, 50);
            pnlSuperiorEdit.TabIndex = 0;
            // 
            // pnlSuperiorEdit2
            // 
            pnlSuperiorEdit2.BackColor = SystemColors.InactiveCaption;
            pnlSuperiorEdit2.Controls.Add(lblGestionEditorial);
            pnlSuperiorEdit2.Dock = DockStyle.Top;
            pnlSuperiorEdit2.Location = new Point(0, 50);
            pnlSuperiorEdit2.Name = "pnlSuperiorEdit2";
            pnlSuperiorEdit2.Size = new Size(1628, 55);
            pnlSuperiorEdit2.TabIndex = 1;
            // 
            // lblGestionEditorial
            // 
            lblGestionEditorial.AutoSize = true;
            lblGestionEditorial.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionEditorial.ForeColor = SystemColors.HotTrack;
            lblGestionEditorial.Location = new Point(604, 14);
            lblGestionEditorial.Name = "lblGestionEditorial";
            lblGestionEditorial.Size = new Size(317, 25);
            lblGestionEditorial.TabIndex = 0;
            lblGestionEditorial.Text = "GESTIÓN DE EDITORIALES";
            lblGestionEditorial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDatosEdit
            // 
            pnlDatosEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatosEdit.Controls.Add(btnCancelar);
            pnlDatosEdit.Controls.Add(btnEliminar);
            pnlDatosEdit.Controls.Add(btnEditar);
            pnlDatosEdit.Controls.Add(btnGuardar);
            pnlDatosEdit.Controls.Add(btnNuevo);
            pnlDatosEdit.Controls.Add(txtNombre);
            pnlDatosEdit.Controls.Add(lblNombreEdit);
            pnlDatosEdit.Location = new Point(0, 111);
            pnlDatosEdit.Name = "pnlDatosEdit";
            pnlDatosEdit.Size = new Size(1628, 202);
            pnlDatosEdit.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(939, 137);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar:";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(831, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 25);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar:";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(723, 137);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 25);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar: ";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(617, 137);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 25);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar: ";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(509, 137);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 25);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo:";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(721, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombreEdit
            // 
            lblNombreEdit.AutoSize = true;
            lblNombreEdit.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEdit.Location = new Point(597, 52);
            lblNombreEdit.Name = "lblNombreEdit";
            lblNombreEdit.Size = new Size(80, 18);
            lblNombreEdit.TabIndex = 0;
            lblNombreEdit.Text = "Nombre:";
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AllowUserToAddRows = false;
            dgvEditoriales.AllowUserToDeleteRows = false;
            dgvEditoriales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.BackgroundColor = SystemColors.Window;
            dgvEditoriales.BorderStyle = BorderStyle.Fixed3D;
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(30, 364);
            dgvEditoriales.MultiSelect = false;
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.ReadOnly = true;
            dgvEditoriales.RowHeadersVisible = false;
            dgvEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEditoriales.Size = new Size(1577, 306);
            dgvEditoriales.TabIndex = 3;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // frmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 729);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlDatosEdit);
            Controls.Add(pnlSuperiorEdit2);
            Controls.Add(pnlSuperiorEdit);
            Name = "frmEditoriales";
            Text = "frmEditoriales";
            pnlSuperiorEdit2.ResumeLayout(false);
            pnlSuperiorEdit2.PerformLayout();
            pnlDatosEdit.ResumeLayout(false);
            pnlDatosEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperiorEdit;
        private Panel pnlSuperiorEdit2;
        private Label lblGestionEditorial;
        private Panel pnlDatosEdit;
        private Label lblNombreEdit;
        private Button btnNuevo;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private DataGridView dgvEditoriales;
    }
}