using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace proyecto
{
    public partial class Form3 : Form
    {


        
        public Form3()
        {
            InitializeComponent();
        }
        DataClasses1DataContext valor = new DataClasses1DataContext();
        void cargarGrid()
        {

            var cargaGrid = from p in valor.recambios select p;
            dataGridView1.DataSource = cargaGrid;

                           






        }


        void cargarCombo()
        {
            var cargaCombo = from p in valor.recambios
                             select p.id;
            comboBox1.DataSource = cargaCombo;





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtProducto.Text == "") || (txtPrecio.Text == "") || (txtUnidades.Text == "") || (txtCaracteristicas.Text == ""))




                {
                    MessageBox.Show("Faltan dator por introducir");



                }
                else
                {
                    recambios MyProduct = new recambios();
                    MyProduct.producto = txtProducto.Text;
                    MyProduct.precio = int.Parse(txtPrecio.Text);
                    MyProduct.unidades = int.Parse(txtUnidades.Text);
                    MyProduct.caracteristicas = txtCaracteristicas.Text;
                    valor.recambios.InsertOnSubmit(MyProduct);
                    valor.SubmitChanges();
                    cargarGrid();
                    cargarCombo();
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                    txtUnidades.Text = "";
                    txtCaracteristicas.Text = "";


                }
            } catch
            {
                MessageBox.Show("Se ha producido un error");
               

            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.recambios' Puede moverla o quitarla según sea necesario.
            this.recambiosTableAdapter.Fill(this.proyectoDataSet.recambios);
            cargarGrid();
            cargarCombo();



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProducto.Text == "") || (txtPrecio.Text == "") || (txtUnidades.Text == "") || (txtCaracteristicas.Text == ""))
                {

                    MessageBox.Show("Faltan datos por introducir");


                }
                else
                {

                    recambios MyProducto = valor.recambios.Single(p => p.id == int.Parse(comboBox1.SelectedItem.ToString()));
                    MyProducto.producto = txtProducto.Text;
                    MyProducto.precio = int.Parse(txtPrecio.Text);
                    MyProducto.unidades = int.Parse(txtUnidades.Text);
                    MyProducto.caracteristicas = txtCaracteristicas.Text;
                    valor.SubmitChanges();
                    cargarGrid();
                    cargarCombo();
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                    txtUnidades.Text = "";
                    txtCaracteristicas.Text = "";


                }
            } catch
            {
                MessageBox.Show("Se ha producido un error");


            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                if (comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("No quedan productos");


                }
                else
                {
                    recambios MyProduct = valor.recambios.Single(p => p.id == int.Parse(comboBox1.SelectedItem.ToString()));
                    valor.recambios.DeleteOnSubmit(MyProduct);
                    valor.SubmitChanges();
                    cargarGrid();
                    cargarCombo();


                }

                


            } catch
            {
                MessageBox.Show("Se ha producido un error");


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();

            } catch
            {


                MessageBox.Show("Se ha producido un error");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO exportar a pdf.
           




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\sample.txt");
            try
            {
                string sLine = "";

                
                for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                {
                   
                    for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                           
                            sLine = sLine + ",";
                        }
                    }
                   
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }
    }
}
