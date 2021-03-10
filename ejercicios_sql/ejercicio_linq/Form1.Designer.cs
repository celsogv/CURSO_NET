
namespace ejercicio_linq
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGuardar2 = new System.Windows.Forms.Button();
            this.TxtCat = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.TxtPrec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGuardar2);
            this.groupBox1.Controls.Add(this.TxtCat);
            this.groupBox1.Controls.Add(this.Categoria);
            this.groupBox1.Controls.Add(this.TxtPrec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.TxtStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtProd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO PRODUCTO";
            // 
            // BtnGuardar2
            // 
            this.BtnGuardar2.Location = new System.Drawing.Point(235, 219);
            this.BtnGuardar2.Name = "BtnGuardar2";
            this.BtnGuardar2.Size = new System.Drawing.Size(88, 29);
            this.BtnGuardar2.TabIndex = 9;
            this.BtnGuardar2.Text = "Actualizar";
            this.BtnGuardar2.UseVisualStyleBackColor = true;
            this.BtnGuardar2.Click += new System.EventHandler(this.BtnGuardar2_Click);
            // 
            // TxtCat
            // 
            this.TxtCat.Location = new System.Drawing.Point(229, 142);
            this.TxtCat.Name = "TxtCat";
            this.TxtCat.Size = new System.Drawing.Size(100, 22);
            this.TxtCat.TabIndex = 8;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(241, 106);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(69, 17);
            this.Categoria.TabIndex = 7;
            this.Categoria.Text = "Categoria";
            // 
            // TxtPrec
            // 
            this.TxtPrec.Location = new System.Drawing.Point(223, 65);
            this.TxtPrec.Name = "TxtPrec";
            this.TxtPrec.Size = new System.Drawing.Size(100, 22);
            this.TxtPrec.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio Unidad";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(64, 212);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(74, 36);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Añadir";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(51, 142);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(100, 22);
            this.TxtStock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidades En Stock";
            // 
            // TxtProd
            // 
            this.TxtProd.Location = new System.Drawing.Point(51, 65);
            this.TxtProd.Name = "TxtProd";
            this.TxtProd.Size = new System.Drawing.Size(100, 22);
            this.TxtProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre del producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(492, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(637, 87);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(151, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar Producto";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(432, 165);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.RowHeadersWidth = 51;
            this.GridDatos.RowTemplate.Height = 24;
            this.GridDatos.Size = new System.Drawing.Size(332, 242);
            this.GridDatos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrec;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox TxtCat;
        private System.Windows.Forms.Button BtnGuardar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView GridDatos;
    }
}

