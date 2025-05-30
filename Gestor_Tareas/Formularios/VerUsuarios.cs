using Dapper.Contrib.Extensions;
using Gestor_Tareas.Clases;
using ScottPlot;
using ScottPlot.TickGenerators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace Gestor_Tareas.Formularios
{
    public partial class VerUsuarios : Form
    {
        string conexion = @"Data Source=localhost;Initial Catalog=Gestor_Tareas;Integrated Security=SSPI";

        public VerUsuarios()
        {
            InitializeComponent();
            llenarCmb();
            cmbSeleccionarPorID.SelectedIndex = 1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void llenarCmb()
        {
            using (IDbConnection db = new SqlConnection(conexion))
            {
                var usuarios = db.GetAll<Usuarios>().ToList();

                foreach (var usuario in usuarios)
                {
                    cmbSeleccionarPorID.Items.Add(usuario.ID);
                }
            }
        }

        private void cmbSeleccionarPorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarTareas();
        }

        private void mostrarTareas()
        {
            chckLstBoxTareasSinHacer.Items.Clear();
            chckLstBoxTareasTerminadas.Items.Clear();

            using (IDbConnection db = new SqlConnection(conexion))
            {
                var tareas = db.GetAll<Tareas>().ToList();
                var usuarios = db.GetAll<Usuarios>().ToList();
                var usuarioSeleccionado = usuarios[cmbSeleccionarPorID.SelectedIndex];

                var tareasUsuario = new List<Tareas>();

                foreach (var tarea in tareas)
                {
                    if (tarea.ID_Usuario == usuarioSeleccionado.ID)
                    {
                        tareasUsuario.Add(tarea);

                        if (tarea.terminada == false)
                        {
                            chckLstBoxTareasSinHacer.Items.Add(tarea);
                        }
                        else
                        {
                            chckLstBoxTareasTerminadas.Items.Add(tarea);
                        }
                    }
                }

                graficarTareas(tareasUsuario);
            }
        }


        private void btnTerminarTarea_Click(object sender, EventArgs e)
        {
            if (chckLstBoxTareasSinHacer.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una o mas tareas que hayas completado");
                return;
            }

            using (IDbConnection db = new SqlConnection(conexion))
            {
                foreach (Tareas t in chckLstBoxTareasSinHacer.CheckedItems)
                {
                    t.terminada = true;
                    db.Update(t);
                }
            }

            mostrarTareas();

        }

        private void btnTareaPendiente_Click(object sender, EventArgs e)
        {
            if (chckLstBoxTareasTerminadas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una o mas tareas que ahora esten pendientes");
                return;
            }

            using (IDbConnection db = new SqlConnection(conexion))
            {
                foreach (Tareas t in chckLstBoxTareasTerminadas.CheckedItems)
                {
                    t.terminada = false;
                    db.Update(t);
                }
            }

            mostrarTareas();
        }

        private void graficarTareas(List<Tareas> tareas)
        {
            formsPlot1.Plot.Clear();

            if (tareas.Count == 0)
            {
                formsPlot1.Plot.Title("No hay tareas para mostrar");
                formsPlot1.Refresh();
                lblPendientes.Visible = false;
                lblTerminadas.Visible = false;
                return;
            }

            int terminadas = tareas.Count(t => t.terminada);
            int pendientes = tareas.Count - terminadas;

            double[] valores = { terminadas, pendientes };

            var pie = formsPlot1.Plot.Add.Pie(valores);

            var verde = new ScottPlot.Color(0, 128, 0);
            var rojo = new ScottPlot.Color(255, 0, 0);

            pie.Slices[0].FillColor = verde;
            pie.Slices[1].FillColor = rojo;

            //Para ponerlas en la grafica
            //pie.Slices[0].Label = $"Terminadas ({(double)terminadas / tareas.Count * 100:0.00}%)";
            //pie.Slices[1].Label = $"Pendientes ({(double)pendientes / tareas.Count * 100:0.00}%)";

            lblTerminadas.Text = $"Terminadas ({(double)terminadas / tareas.Count * 100:0.00}%)";
            lblPendientes.Text = $"Pendientes ({(double)pendientes / tareas.Count * 100:0.00}%)";


            formsPlot1.Plot.Title("Estado de tareas");
            formsPlot1.Refresh();
            formsPlot1.Plot.Axes.Bottom.TickGenerator = new NumericManual(new double[] { }, new string[] { });
            formsPlot1.Plot.Axes.Left.TickGenerator = new NumericManual(new double[] { }, new string[] { });
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            this.Hide();
        }
    }
}
