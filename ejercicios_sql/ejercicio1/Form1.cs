using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {

        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarclientes();



        }




        void listarclientes() {
            ClienteLinq.listartodos();
            GridDatos.DataSource = ClienteLinq.listartodos();

        
        }




        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellido1.Clear();
            TxtApellido2.Clear();
            TxtTelefono.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarCliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.listarclientes();



        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
            this.listarclientes();

        }
    }
}
