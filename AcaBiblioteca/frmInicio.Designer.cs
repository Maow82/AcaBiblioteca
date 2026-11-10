namespace AcaBiblioteca
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            pnlBienvenida = new Panel();
            lblBienvenida = new Label();
            pictureBox1 = new PictureBox();
            pnlBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBienvenida
            // 
            pnlBienvenida.BackColor = Color.AliceBlue;
            pnlBienvenida.Controls.Add(lblBienvenida);
            pnlBienvenida.Dock = DockStyle.Top;
            pnlBienvenida.Location = new Point(0, 0);
            pnlBienvenida.Name = "pnlBienvenida";
            pnlBienvenida.Size = new Size(1491, 140);
            pnlBienvenida.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.HotTrack;
            lblBienvenida.Location = new Point(466, 41);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(445, 38);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a tu Biblioteca";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1453, 549);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 697);
            Controls.Add(pictureBox1);
            Controls.Add(pnlBienvenida);
            Name = "frmInicio";
            Text = "frnInicio";
            pnlBienvenida.ResumeLayout(false);
            pnlBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBienvenida;
        private Label lblBienvenida;
        private PictureBox pictureBox1;
    }
}