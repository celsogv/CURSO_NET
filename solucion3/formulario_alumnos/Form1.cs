using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_alumnos
{
    public partial class Form1 : Form
    {
        Profesor profesor = new Profesor();
        Estudiante estudiante = new Estudiante();
        string valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valor == "profesor")
            {
                profesor.Nombre = txtNombre.Text;
                profesor.sueldo = double.Parse(txtSueldo.Text);
                estudiante.Calificacion = int.Parse(txtCalificacion.Text);


            } else if (valor == "estudiante")
            {
                estudiante.Nombre = txtNombre.Text;
                estudiante.Calificacion = int.Parse(txtCalificacion.Text);



            }
        }

        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {
            txtCalificacion.Visible = true;
            valor = "profesor";
        }

        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtCalificacion.Visible = false;
            valor = "estudiante";
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (valor == "profesor")
            {
                MessageBox.Show("Nombre: " + profesor.Nombre + " Sueldo: " + profesor.sueldo + " " + profesor.Ensenar());


            }
            else if (valor == "estudiante")
            {

                MessageBox.Show("Nombre: " + estudiante.Nombre + " Calificacion: " +estudiante.Calificacion + " " + estudiante.Estudiar());


            }
        }
    }
}
