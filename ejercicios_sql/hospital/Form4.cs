using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class Form4 : Form
    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();


        public Form4()
        {
            InitializeComponent();
            this.versalas();

        }

        void versalas()
        {



            dataGridView1.DataSource = ClienteLinq.listarsalas();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtCodHos.Text == "")
                {

                    MessageBox.Show("Falta el codigo del hospital");



                }
                else if (txtCodSa.Text == "")
                {

                    MessageBox.Show("Falta el codigo de la sala");



                }
                else if (txtNom.Text == "")
                {
                    MessageBox.Show("Falta el nombre");



                }
                else if (txtEspecialidad.Text == "")
                {

                    MessageBox.Show("Falta la especialidad");



                }
                else
                {

                    
                    ClienteLinq.insertarsala(int.Parse(txtCodSa.Text), int.Parse(txtCodHos.Text), txtNom.Text, txtEspecialidad.Text);
                    this.versalas();






                }

            } catch
            {

                MessageBox.Show("Se ha producido un error");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCodHos.Text == "")
                {

                    MessageBox.Show("Falta el codigo del hospital");



                }
                else if (txtCodSa.Text == "")
                {

                    MessageBox.Show("Falta el codigo de la sala");



                }
                else if (txtNom.Text == "")
                {
                    MessageBox.Show("Falta el nombre");



                }
                else if (txtEspecialidad.Text == "")
                {

                    MessageBox.Show("Falta la especialidad");



                }
                else
                {

                    
                    ClienteLinq.modificarsala2(int.Parse(txtCodHos.Text), int.Parse(txtCodSa.Text), txtNom.Text, txtEspecialidad.Text);
                    this.versalas();










                }
            } catch
            {

                MessageBox.Show("Se ha producido un error");



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCodSa.Text == "")
                {
                    MessageBox.Show("Falta el codigo de la sala");



                }
                else
                {
                    
                    ClienteLinq.eliminarsala(int.Parse(txtCodSa.Text));
                    this.versalas();


                }

            } catch
            {

                MessageBox.Show("Se ha producido ub error");



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {


                MessageBox.Show("Se ha producido un error");


            }
        }
    }
}
