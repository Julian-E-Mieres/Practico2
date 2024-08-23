namespace Practico2
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LAya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TGuardar = new System.Windows.Forms.Button();
            this.TEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAya
            // 
            this.LAya.AutoSize = true;
            this.LAya.Location = new System.Drawing.Point(26, 25);
            this.LAya.Name = "LAya";
            this.LAya.Size = new System.Drawing.Size(122, 16);
            this.LAya.TabIndex = 0;
            this.LAya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(178, 25);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(26, 64);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 16);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(26, 111);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 16);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            this.LApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(26, 155);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(56, 16);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(142, 61);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(120, 22);
            this.TDni.TabIndex = 5;
            this.TDni.Click += new System.EventHandler(this.TDni_Click);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(142, 105);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(118, 22);
            this.TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(142, 149);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(118, 22);
            this.TNombre.TabIndex = 7;
            // 
            // TGuardar
            // 
            this.TGuardar.Location = new System.Drawing.Point(38, 229);
            this.TGuardar.Name = "TGuardar";
            this.TGuardar.Size = new System.Drawing.Size(96, 38);
            this.TGuardar.TabIndex = 8;
            this.TGuardar.Text = "Guardar";
            this.TGuardar.UseVisualStyleBackColor = true;
            this.TGuardar.Click += new System.EventHandler(this.TGuardar_Click);
            // 
            // TEliminar
            // 
            this.TEliminar.Location = new System.Drawing.Point(165, 229);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(95, 37);
            this.TEliminar.TabIndex = 9;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.TEliminar);
            this.Controls.Add(this.TGuardar);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LAya);
            this.Name = "Form2";
            this.Text = "Pequeño Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button TGuardar;
        private System.Windows.Forms.Button TEliminar;
    }
}

