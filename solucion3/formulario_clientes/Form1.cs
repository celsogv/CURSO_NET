using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_clientes
{
    public partial class Form1 : Form


        
    {



        Cliente cliente = new Cliente();
    public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnMayorEdad_Click(object sender, EventArgs e)
        {
            cliente._strNombre = txtNombre.Text;
            cliente.FechaNacimiento = DateTime.Parse(dtmFechaNacimiento.Text);
            







        }
    }
}
