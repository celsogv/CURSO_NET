
namespace hospital
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ejercicio_hospitalDataSet = new hospital.ejercicio_hospitalDataSet();
            this.ejerciciohospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter = new hospital.ejercicio_hospitalDataSetTableAdapters.HospitalTableAdapter();
            this.hospitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio_hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejerciciohospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hospitalBindingSource1, "Hospital_cod", true));
            this.comboBox1.DataSource = this.hospitalBindingSource;
            this.comboBox1.DisplayMember = "Hospital_cod";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Hospital_cod";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ejercicio_hospitalDataSet
            // 
            this.ejercicio_hospitalDataSet.DataSetName = "ejercicio_hospitalDataSet";
            this.ejercicio_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ejerciciohospitalDataSetBindingSource
            // 
            this.ejerciciohospitalDataSetBindingSource.DataSource = this.ejercicio_hospitalDataSet;
            this.ejerciciohospitalDataSetBindingSource.Position = 0;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            this.hospitalBindingSource.DataSource = this.ejerciciohospitalDataSetBindingSource;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalBindingSource1
            // 
            this.hospitalBindingSource1.DataMember = "Hospital";
            this.hospitalBindingSource1.DataSource = this.ejercicio_hospitalDataSet;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicio_hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejerciciohospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ejerciciohospitalDataSetBindingSource;
        private ejercicio_hospitalDataSet ejercicio_hospitalDataSet;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private ejercicio_hospitalDataSetTableAdapters.HospitalTableAdapter hospitalTableAdapter;
        private System.Windows.Forms.BindingSource hospitalBindingSource1;
    }
}