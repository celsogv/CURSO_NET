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
using System.Windows.Shapes;

namespace ejercicio_entity
{
    /// <summary>
    /// Lógica de interacción para VentanaModificar.xaml
    /// </summary>
    public partial class VentanaModificar : Window

    {


        ejercicio_entityEntities1 DbEntityes = new ejercicio_entityEntities1();
        int id;

        public VentanaModificar(int IdProfesor)
        {
            InitializeComponent();
            id = IdProfesor;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Profesores Myprofe = (from m in DbEntityes.Profesores where m.id == id select m).Single();
                Myprofe.Nombre = TxtNombre.Text;
                Myprofe.Especialidad = cmbEspec.Text;
                DbEntityes.SaveChanges();
                MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
                this.Hide();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }

        }
    }
}
