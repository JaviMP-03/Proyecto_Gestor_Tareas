using Dapper.Contrib.Extensions;
using Gestor_Tareas.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_Tareas.Formularios
{
    public partial class DeleteUsuarios : Form
    {
        string conexion = @"Data Source=localhost;Initial Catalog=Gestor_Tareas;Integrated Security=SSPI";

        public DeleteUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            llenarCmbIds();
            cmbUsers.SelectedIndex = 0;
            this.ControlBox = false;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            this.Close();
            menuPrincipal.Show();
        }

        private void btnDelTareas_Click(object sender, EventArgs e)
        {
            if (chcklstboxTareas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una o mas tareas");
            }
            else
            {
                delTarea();
            }
        }

        private void delTarea()
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var tareasSeleccionadas = chcklstboxTareas.CheckedItems.Cast<Tareas>().ToList();

                foreach (Tareas t in tareasSeleccionadas)
                {
                    db.Delete(t);
                }
            }

            mostrarTareas();

            MessageBox.Show("Las tareas se han eliminado con éxito");
        }


        private void llenarCmbIds()
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuarios = db.GetAll<Usuarios>().ToList();

                foreach (var u in usuarios)
                {
                    cmbUsers.Items.Add(u.ID);
                    cmbDelUsuario.Items.Add(u.ID);
                }
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarTareas();
        }

        private void mostrarTareas()
        {
            chcklstboxTareas.Items.Clear();
            using (IDbConnection db = new SqlConnection(conexion))
            {
                int id = Convert.ToInt32(cmbUsers.SelectedItem);
                var allTareas = db.GetAll<Tareas>().ToList();

                foreach (var t in allTareas)
                {
                    if (t.ID_Usuario == id && t.terminada == false)
                    {
                        chcklstboxTareas.Items.Add(t);
                    }
                }
            }
        }

        private void btnDelUsuario_Click(object sender, EventArgs e)
        {

            if (cmbDelUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un usuario");
                return;
            }

            using (IDbConnection db = new SqlConnection(conexion))
            {
                int id = Convert.ToInt32(cmbDelUsuario.SelectedItem);
                var usuario = db.Get<Usuarios>(id);
                var tareas = db.GetAll<Tareas>().ToList();

                foreach (var t in tareas)
                {
                    if (t.ID_Usuario == id)
                    {
                        db.Delete(t);
                    }
                }
                cmbUsers.SelectedIndex = -1;
                cmbDelUsuario.SelectedIndex = -1;
                db.Delete(usuario);
            }

            MessageBox.Show("Se ha borrado el usuario y sus tareas");
        }
    }
}
