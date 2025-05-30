using System;
using System.Windows.Forms;

namespace Gestor_Tareas.Formularios
{
    public partial class MenuPrincipal : Form
    {
        string conexion = @"Data Source=localhost;Initial Catalog=Gestor_Tareas;Integrated Security=SSPI";

        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios v = new VerUsuarios();
            v.ShowDialog();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnAddUsuarios_Click(object sender, EventArgs e)
        {
            AddUsuarios addUsuarios = new AddUsuarios();
            addUsuarios.ShowDialog();
            this.Hide();
        }

        private void btnDelUsuarios_Click(object sender, EventArgs e)
        {
            DeleteUsuarios delUsuarios = new DeleteUsuarios();
            delUsuarios.ShowDialog();
            this.Hide();
        }

        private void btnActualizarUsuarios_Click(object sender, EventArgs e)
        {
            UpdateUsuarios updateUsuarios = new UpdateUsuarios();
            updateUsuarios.ShowDialog();
            this.Hide();
        }
    }
}
