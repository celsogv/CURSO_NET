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
    /// Lógica de interacción para VentanaInsertar.xaml
    /// </summary>
    public partial class VentanaInsertar : Window
    {

        ejercicio_entityEntities1 DbEntityes = new ejercicio_entityEntities1();
        public VentanaInsertar()
        {
            InitializeComponent();
        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                Profesores MyProfe = new Profesores()
                {

                    id = int.Parse(TxtID.Text),
                    Nombre = TxtNombre.Text,
                    Especialidad = cmbEspec.Text





                };
                DbEntityes.Profesores.Add(MyProfe);
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
