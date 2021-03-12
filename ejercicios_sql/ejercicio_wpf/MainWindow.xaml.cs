using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ejercicio_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cargarGrid();
        }
        DataClasses1DataContext curso = new DataClasses1DataContext();
        bool repetidor = false;
        void cargarGrid()
        {
            var cargaGrid = from p in curso.alumnos select p;
            dataGridView1.ItemsSource = cargaGrid;



        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                alumnos MyAlumno = new alumnos();
                MyAlumno.Codigo = txtCodigo.Text;
                MyAlumno.Nombre = txtNombre.Text;
                MyAlumno.DNI = txtDni.Text;
                MyAlumno.Turno = txtTurno.Text;
                MyAlumno.Sexo = txtSexo.Text;
                MyAlumno.Repetidor = repetidor;
                MyAlumno.Modulo = txtModulo.Text;
                MyAlumno.Especialidad = txtEspecialidad.Text;
                curso.alumnos.InsertOnSubmit(MyAlumno);
                curso.SubmitChanges();
                cargarGrid();

            } catch
            {

                MessageBox.Show("Se ha producido un error");


            }






        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            repetidor = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                alumnos MyAlumno = curso.alumnos.Single(p => p.Codigo == txtCodigo.Text);
                curso.alumnos.DeleteOnSubmit(MyAlumno);
                curso.SubmitChanges();
                cargarGrid();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            try
            {
                alumnos MyAlumno = curso.alumnos.Single(p => p.Codigo == txtCodigo.Text);
                MyAlumno.Codigo = txtCodigo.Text;
                MyAlumno.Nombre = txtNombre.Text;
                MyAlumno.DNI = txtDni.Text;
                MyAlumno.Turno = txtTurno.Text;
                MyAlumno.Sexo = txtSexo.Text;
                MyAlumno.Repetidor = repetidor;
                MyAlumno.Modulo = txtModulo.Text;
                curso.SubmitChanges();
                
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                var cargaGrid = from p in curso.alumnos where p.Codigo == busquedaCodigo.Text select p;
                dataGridView1.ItemsSource = cargaGrid;

            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                var cargaGrid = from p in curso.alumnos where p.DNI == busquedaDni.Text.ToString() select p;
                dataGridView1.ItemsSource = cargaGrid;

            }
            catch
            {
                MessageBox.Show("Se ha producido un error");



            }
        }
    }
}
