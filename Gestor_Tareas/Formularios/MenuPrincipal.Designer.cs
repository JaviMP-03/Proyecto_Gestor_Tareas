namespace Gestor_Tareas.Formularios
{
    partial class MenuPrincipal
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
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAddUsuarios = new System.Windows.Forms.Button();
            this.btnActualizarUsuarios = new System.Windows.Forms.Button();
            this.btnDelUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerUsuarios.Location = new System.Drawing.Point(289, 130);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(128, 79);
            this.btnVerUsuarios.TabIndex = 0;
            this.btnVerUsuarios.Text = "Ver usuarios";
            this.btnVerUsuarios.UseVisualStyleBackColor = true;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnVerUsuarios_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1240, 662);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(106, 63);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAddUsuarios
            // 
            this.btnAddUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUsuarios.Location = new System.Drawing.Point(516, 130);
            this.btnAddUsuarios.Name = "btnAddUsuarios";
            this.btnAddUsuarios.Size = new System.Drawing.Size(128, 79);
            this.btnAddUsuarios.TabIndex = 2;
            this.btnAddUsuarios.Text = "Añadir usuarios y/o tareas";
            this.btnAddUsuarios.UseVisualStyleBackColor = true;
            this.btnAddUsuarios.Click += new System.EventHandler(this.btnAddUsuarios_Click);
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(1000, 130);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(128, 79);
            this.btnActualizarUsuarios.TabIndex = 4;
            this.btnActualizarUsuarios.Text = "Actualizar usuarios";
            this.btnActualizarUsuarios.UseVisualStyleBackColor = true;
            this.btnActualizarUsuarios.Click += new System.EventHandler(this.btnActualizarUsuarios_Click);
            // 
            // btnDelUsuarios
            // 
            this.btnDelUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelUsuarios.Location = new System.Drawing.Point(773, 130);
            this.btnDelUsuarios.Name = "btnDelUsuarios";
            this.btnDelUsuarios.Size = new System.Drawing.Size(128, 79);
            this.btnDelUsuarios.TabIndex = 3;
            this.btnDelUsuarios.Text = "Eliminar usuarios y/o tareas";
            this.btnDelUsuarios.UseVisualStyleBackColor = true;
            this.btnDelUsuarios.Click += new System.EventHandler(this.btnDelUsuarios_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1433, 762);
            this.Controls.Add(this.btnActualizarUsuarios);
            this.Controls.Add(this.btnDelUsuarios);
            this.Controls.Add(this.btnAddUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnVerUsuarios);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAddUsuarios;
        private System.Windows.Forms.Button btnActualizarUsuarios;
        private System.Windows.Forms.Button btnDelUsuarios;
    }
}