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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Falta el usuario");



            } else if (txtContrasena.Text == "")
            {

                MessageBox.Show("Falta contraseña");


            } else if (txtUsuario.Text != "user") {

                MessageBox.Show("Usuario incorrecto");

                

            } else if(txtContrasena.Text != "password")
            {

                MessageBox.Show("Contraseña incorrecta");


            } else
            {

                
                MDIParent1 valor = new MDIParent1();
                valor.Show();
                this.Hide();




            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
