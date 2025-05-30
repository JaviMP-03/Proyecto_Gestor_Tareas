namespace Gestor_Tareas.Formularios
{
    partial class UpdateUsuarios
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
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIds = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.chckMostrarPasswd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(1201, 629);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(113, 66);
            this.btnMenuPrincipal.TabIndex = 0;
            this.btnMenuPrincipal.Text = "Volver al menu principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(552, 524);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 76);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar usuario";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Usuario";
            // 
            // cmbIds
            // 
            this.cmbIds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIds.FormattingEnabled = true;
            this.cmbIds.Location = new System.Drawing.Point(552, 113);
            this.cmbIds.Name = "cmbIds";
            this.cmbIds.Size = new System.Drawing.Size(154, 24);
            this.cmbIds.TabIndex = 3;
            this.cmbIds.SelectedIndexChanged += new System.EventHandler(this.cmbIds_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(552, 266);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(552, 435);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(154, 22);
            this.txtPasswd.TabIndex = 7;
            // 
            // chckMostrarPasswd
            // 
            this.chckMostrarPasswd.AutoSize = true;
            this.chckMostrarPasswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckMostrarPasswd.Location = new System.Drawing.Point(736, 437);
            this.chckMostrarPasswd.Name = "chckMostrarPasswd";
            this.chckMostrarPasswd.Size = new System.Drawing.Size(146, 20);
            this.chckMostrarPasswd.TabIndex = 8;
            this.chckMostrarPasswd.Text = "Mostrar Contraseña";
            this.chckMostrarPasswd.UseVisualStyleBackColor = true;
            this.chckMostrarPasswd.CheckedChanged += new System.EventHandler(this.chckMostrarPasswd_CheckedChanged);
            // 
            // UpdateUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1405, 736);
            this.Controls.Add(this.chckMostrarPasswd);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Name = "UpdateUsuarios";
            this.Text = "UpdateUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.CheckBox chckMostrarPasswd;
    }
}