
namespace formulario_clientes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmFechaActual = new System.Windows.Forms.DateTimePicker();
            this.btnMayorEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(281, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(457, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // dtmFechaNacimiento
            // 
            this.dtmFechaNacimiento.Location = new System.Drawing.Point(364, 267);
            this.dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            this.dtmFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtmFechaNacimiento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "fecha actual";
            // 
            // dtmFechaActual
            // 
            this.dtmFechaActual.Location = new System.Drawing.Point(364, 449);
            this.dtmFechaActual.Name = "dtmFechaActual";
            this.dtmFechaActual.Size = new System.Drawing.Size(200, 22);
            this.dtmFechaActual.TabIndex = 5;
            // 
            // btnMayorEdad
            // 
            this.btnMayorEdad.Location = new System.Drawing.Point(378, 515);
            this.btnMayorEdad.Name = "btnMayorEdad";
            this.btnMayorEdad.Size = new System.Drawing.Size(159, 76);
            this.btnMayorEdad.TabIndex = 6;
            this.btnMayorEdad.Text = "Detectar si es mayor de edad";
            this.btnMayorEdad.UseVisualStyleBackColor = true;
            this.btnMayorEdad.Click += new System.EventHandler(this.btnMayorEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 655);
            this.Controls.Add(this.btnMayorEdad);
            this.Controls.Add(this.dtmFechaActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmFechaNacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmFechaNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmFechaActual;
        private System.Windows.Forms.Button btnMayorEdad;
    }
}

