using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_contraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;
            usuario = txtUsuario.Text.Trim();
            contrasena = txtContrasena.Text.TrimEnd();
            Form2 formulariocrucigrama = new Form2();
            if ((usuario == "Ofimega") && (contrasena == "danone"))
            {
                formulariocrucigrama.Show();

            }
            else
            {

                MessageBox.Show("Acceso denegado");

            }

        }
    }
}
