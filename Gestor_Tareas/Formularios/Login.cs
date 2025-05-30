using Dapper.Contrib.Extensions;
using Gestor_Tareas.Clases;
using Gestor_Tareas.Formularios;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_Tareas
{
    public partial class Login : Form
    {
        string conexion = @"Data Source=localhost;Initial Catalog=Gestor_Tareas;Integrated Security=SSPI";

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty)
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                inicioSesion(usuario, contraseña);
            }
            else
            {
                MessageBox.Show("Uno o mas campos están vacios");
            }
        }

        private void inicioSesion(string usuario, string contraseña)
        {
            bool iniciado = false;
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuarios = db.GetAll<Usuarios>().ToList();

                foreach (Usuarios u in usuarios)
                {
                    if (u.Nombre.Equals(usuario) && u.contraseña.Equals(contraseña))
                    {
                        MessageBox.Show("Bienvenido");
                        iniciado = true;
                        MenuPrincipal m = new MenuPrincipal();
                        m.Show();
                        this.Hide();
                        break;
                    }
                }

                if (!iniciado)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
        }

        private void chcVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chcVerContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
    }
}
