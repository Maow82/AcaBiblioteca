using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //Conexion conexion = new Conexion();
            //try
            //{
               // using (var conn = conexion.ObtenerConexion())
                //{
                   // conn.Open();
                    //La conexion se ha establesido correctamente
                   // MessageBox.Show("Conexion a la Base de Datos establecida correctamente.",
                   //   "AcaBiblioteca,",
                    //  MessageBoxButtons.OK,
                   //    MessageBoxIcon.Information);
                //}
         //   }
            //catch (Exception  ex)
            //{
            //    MessageBox.Show("Error al conectar la Base de Datos: " + ex.Message,
            //      "AcaBiblioteca",
           //        MessageBoxButtons.OK,
           //         MessageBoxIcon.Error);
           //  }

            AbrirFormulario(new frmInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicio());
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLibros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAutores());
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEditoriales());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPrestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReportes());

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
