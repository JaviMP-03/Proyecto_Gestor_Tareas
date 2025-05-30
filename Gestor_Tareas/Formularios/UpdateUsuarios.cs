using Dapper.Contrib.Extensions;
using Gestor_Tareas.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_Tareas.Formularios
{
    public partial class UpdateUsuarios : Form
    {
        string conexion = @"Data Source=localhost;Initial Catalog=Gestor_Tareas;Integrated Security=SSPI";

        public UpdateUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            llenarCmbID();
            cmbIds.SelectedIndex = 0;
            this.ControlBox = false;
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            this.Close();
        }

        private void llenarCmbID()
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuarios = db.GetAll<Usuarios>().ToList();

                foreach (var usuario in usuarios)
                {
                    cmbIds.Items.Add(usuario.ID);
                }

            }
        }

        private void cmbIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbIds.SelectedItem);
            mostrarDatos(id);
        }

        private void mostrarDatos(int id)
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuario = db.Get<Usuarios>(id);

                txtNombre.Text = usuario.Nombre;
                txtPasswd.Text = usuario.contraseña;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)cmbIds.SelectedItem;
            updateUser(id);
        }

        private void updateUser(int id)
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuario = db.Get<Usuarios>(id);
                usuario.Nombre = txtNombre.Text;
                usuario.contraseña = txtPasswd.Text;
                db.Update(usuario);
            }
            mostrarDatos(id);
            MessageBox.Show("Usuario actualizado con exito");
        }

        private void chckMostrarPasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chckMostrarPasswd.Checked)
            {
                txtPasswd.PasswordChar = '\0';
            }
            else
            {
                txtPasswd.PasswordChar = '*';
            }
        }
    }
}
