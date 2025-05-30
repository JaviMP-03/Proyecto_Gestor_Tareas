namespace Gestor_Tareas.Formularios
{
    partial class VerUsuarios
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
            this.cmbSeleccionarPorID = new System.Windows.Forms.ComboBox();
            this.chckLstBoxTareasSinHacer = new System.Windows.Forms.CheckedListBox();
            this.btnTerminarTarea = new System.Windows.Forms.Button();
            this.chckLstBoxTareasTerminadas = new System.Windows.Forms.CheckedListBox();
            this.btnTareaPendiente = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.lblTerminadas = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSeleccionarPorID
            // 
            this.cmbSeleccionarPorID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSeleccionarPorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionarPorID.FormattingEnabled = true;
            this.cmbSeleccionarPorID.Location = new System.Drawing.Point(34, 99);
            this.cmbSeleccionarPorID.Name = "cmbSeleccionarPorID";
            this.cmbSeleccionarPorID.Size = new System.Drawing.Size(204, 24);
            this.cmbSeleccionarPorID.TabIndex = 0;
            this.cmbSeleccionarPorID.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionarPorID_SelectedIndexChanged);
            // 
            // chckLstBoxTareasSinHacer
            // 
            this.chckLstBoxTareasSinHacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckLstBoxTareasSinHacer.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLstBoxTareasSinHacer.FormattingEnabled = true;
            this.chckLstBoxTareasSinHacer.Location = new System.Drawing.Point(299, 99);
            this.chckLstBoxTareasSinHacer.Name = "chckLstBoxTareasSinHacer";
            this.chckLstBoxTareasSinHacer.Size = new System.Drawing.Size(404, 212);
            this.chckLstBoxTareasSinHacer.TabIndex = 1;
            // 
            // btnTerminarTarea
            // 
            this.btnTerminarTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminarTarea.Location = new System.Drawing.Point(420, 355);
            this.btnTerminarTarea.Name = "btnTerminarTarea";
            this.btnTerminarTarea.Size = new System.Drawing.Size(128, 77);
            this.btnTerminarTarea.TabIndex = 2;
            this.btnTerminarTarea.Text = "Marcar como terminada";
            this.btnTerminarTarea.UseVisualStyleBackColor = true;
            this.btnTerminarTarea.Click += new System.EventHandler(this.btnTerminarTarea_Click);
            // 
            // chckLstBoxTareasTerminadas
            // 
            this.chckLstBoxTareasTerminadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckLstBoxTareasTerminadas.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLstBoxTareasTerminadas.FormattingEnabled = true;
            this.chckLstBoxTareasTerminadas.Location = new System.Drawing.Point(869, 99);
            this.chckLstBoxTareasTerminadas.Name = "chckLstBoxTareasTerminadas";
            this.chckLstBoxTareasTerminadas.Size = new System.Drawing.Size(419, 212);
            this.chckLstBoxTareasTerminadas.TabIndex = 3;
            // 
            // btnTareaPendiente
            // 
            this.btnTareaPendiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTareaPendiente.Location = new System.Drawing.Point(1013, 355);
            this.btnTareaPendiente.Name = "btnTareaPendiente";
            this.btnTareaPendiente.Size = new System.Drawing.Size(128, 77);
            this.btnTareaPendiente.TabIndex = 4;
            this.btnTareaPendiente.Text = "Marcar como pendiente";
            this.btnTareaPendiente.UseVisualStyleBackColor = true;
            this.btnTareaPendiente.Click += new System.EventHandler(this.btnTareaPendiente_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.DisplayScale = 0F;
            this.formsPlot1.Enabled = false;
            this.formsPlot1.Location = new System.Drawing.Point(518, 488);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(409, 305);
            this.formsPlot1.TabIndex = 5;
            // 
            // lblTerminadas
            // 
            this.lblTerminadas.AutoSize = true;
            this.lblTerminadas.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminadas.Location = new System.Drawing.Point(295, 582);
            this.lblTerminadas.Name = "lblTerminadas";
            this.lblTerminadas.Size = new System.Drawing.Size(110, 24);
            this.lblTerminadas.TabIndex = 6;
            this.lblTerminadas.Text = "Terminadas";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.Location = new System.Drawing.Point(295, 659);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(108, 24);
            this.lblPendientes.TabIndex = 7;
            this.lblPendientes.Text = "Pendientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccion de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tareas pendientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1009, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tareas completadas";
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(1189, 659);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(99, 70);
            this.btnVolverMenuPrincipal.TabIndex = 11;
            this.btnVolverMenuPrincipal.Text = "Volver al menu principal";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // VerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1405, 975);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblTerminadas);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.btnTareaPendiente);
            this.Controls.Add(this.chckLstBoxTareasTerminadas);
            this.Controls.Add(this.btnTerminarTarea);
            this.Controls.Add(this.chckLstBoxTareasSinHacer);
            this.Controls.Add(this.cmbSeleccionarPorID);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "VerUsuarios";
            this.Text = "VerUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSeleccionarPorID;
        private System.Windows.Forms.CheckedListBox chckLstBoxTareasSinHacer;
        private System.Windows.Forms.Button btnTerminarTarea;
        private System.Windows.Forms.CheckedListBox chckLstBoxTareasTerminadas;
        private System.Windows.Forms.Button btnTareaPendiente;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.Label lblTerminadas;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
    }
}