namespace Gestor_Tareas.Formularios
{
    partial class DeleteUsuarios
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
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chcklstboxTareas = new System.Windows.Forms.CheckedListBox();
            this.btnDelTareas = new System.Windows.Forms.Button();
            this.btnDelUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDelUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.Location = new System.Drawing.Point(1167, 648);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(119, 60);
            this.btnVolverMenu.TabIndex = 0;
            this.btnVolverMenu.Text = "Volver al menu principal";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(372, 123);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(160, 24);
            this.cmbUsers.TabIndex = 1;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Usuario";
            // 
            // chcklstboxTareas
            // 
            this.chcklstboxTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chcklstboxTareas.FormattingEnabled = true;
            this.chcklstboxTareas.Location = new System.Drawing.Point(372, 200);
            this.chcklstboxTareas.Name = "chcklstboxTareas";
            this.chcklstboxTareas.Size = new System.Drawing.Size(287, 276);
            this.chcklstboxTareas.TabIndex = 3;
            // 
            // btnDelTareas
            // 
            this.btnDelTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelTareas.Location = new System.Drawing.Point(429, 553);
            this.btnDelTareas.Name = "btnDelTareas";
            this.btnDelTareas.Size = new System.Drawing.Size(136, 74);
            this.btnDelTareas.TabIndex = 4;
            this.btnDelTareas.Text = "Eliminar tareas";
            this.btnDelTareas.UseVisualStyleBackColor = true;
            this.btnDelTareas.Click += new System.EventHandler(this.btnDelTareas_Click);
            // 
            // btnDelUsuario
            // 
            this.btnDelUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelUsuario.Location = new System.Drawing.Point(848, 553);
            this.btnDelUsuario.Name = "btnDelUsuario";
            this.btnDelUsuario.Size = new System.Drawing.Size(118, 74);
            this.btnDelUsuario.TabIndex = 5;
            this.btnDelUsuario.Text = "Borrar usuario";
            this.btnDelUsuario.UseVisualStyleBackColor = true;
            this.btnDelUsuario.Click += new System.EventHandler(this.btnDelUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(845, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Usuario";
            // 
            // cmbDelUsuario
            // 
            this.cmbDelUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelUsuario.FormattingEnabled = true;
            this.cmbDelUsuario.Location = new System.Drawing.Point(848, 418);
            this.cmbDelUsuario.Name = "cmbDelUsuario";
            this.cmbDelUsuario.Size = new System.Drawing.Size(160, 24);
            this.cmbDelUsuario.TabIndex = 6;
            // 
            // DeleteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1429, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDelUsuario);
            this.Controls.Add(this.btnDelUsuario);
            this.Controls.Add(this.btnDelTareas);
            this.Controls.Add(this.chcklstboxTareas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnVolverMenu);
            this.Name = "DeleteUsuarios";
            this.Text = "DeleteUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chcklstboxTareas;
        private System.Windows.Forms.Button btnDelTareas;
        private System.Windows.Forms.Button btnDelUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDelUsuario;
    }
}