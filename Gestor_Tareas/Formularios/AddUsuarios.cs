using Dapper.Contrib.Extensions;
using Gestor_Tareas.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_Tareas.Formularios
{
    public partial class AddUsuarios : Form
    {
        string conexion = @"Data Source=localhost;Initial Catalog=Gestor_Tareas;Integrated Security=SSPI";

        public AddUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rdbNo.Checked = true;
            llenarcmbIDs();
            cmbUserID.SelectedIndex = 0;
            this.ControlBox = false;
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            this.Close();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtPasswd.Text == string.Empty)
            {
                MessageBox.Show("Porfavor, rellena los campos");
            }
            else
            {
                string nombre = txtNombre.Text;
                string passwd = txtPasswd.Text;
                addUsuario(nombre, passwd);
            }
        }

        private void addUsuario(string nombre, string contraseña)
        {
            Usuarios newUsuario = new Usuarios();
            newUsuario.Nombre = nombre;
            newUsuario.contraseña = contraseña;

            using (IDbConnection db = new SqlConnection(conexion))
            {
                db.Insert(newUsuario);
            }

            MessageBox.Show($"Usuario creado con exito, tu ID asignado es: {newUsuario.ID}");
            txtNombre.Text = string.Empty;
            txtPasswd.Text = string.Empty;
        }

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Porfavor, rellena todos los campos");
            }
            else
            {
                int id = Convert.ToInt32(cmbUserID.SelectedItem);
                string descripcion = txtDescripcion.Text;
                bool terminada;

                if (rdbSi.Checked == true)
                {
                    terminada = true;
                }
                else
                {
                    terminada = false;
                }
                addTarea(id, descripcion, terminada);
            }
        }

        private void addTarea(int id, string descripcion, bool terminada)
        {
            Tareas tarea = new Tareas();
            tarea.ID_Usuario = id;
            tarea.Descripcion = descripcion;
            tarea.terminada = terminada;

            using (IDbConnection db = new SqlConnection(conexion))
            {
                db.Insert(tarea);
            }

            MessageBox.Show("Tarea añadida correctamente");
            cmbUserID.SelectedIndex = 0;
            txtDescripcion.Text = string.Empty;
            rdbNo.Checked = true;
            rdbSi.Checked = false;
        }

        private void llenarcmbIDs()
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuarios = db.GetAll<Usuarios>().ToList();

                foreach (var usuario in usuarios)
                {
                    cmbUserID.Items.Add(usuario.ID);
                }
            }
        }
    }
}
