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

namespace ejercicio_entity
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ejercicio_entityEntities1 DbEntityes = new ejercicio_entityEntities1();
        public static DataGrid ControlDatagrid;



        public MainWindow()
        {
     
            InitializeComponent();
            MyDG.ItemsSource = DbEntityes.Profesores.ToList();
            ControlDatagrid = MyDG;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VentanaInsertar Vinsertar = new VentanaInsertar();
                Vinsertar.ShowDialog();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                int id = (MyDG.SelectedItem as Profesores).id;
                VentanaModificar Vcambiar = new VentanaModificar(id);
                Vcambiar.ShowDialog();
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }
            


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            try
            {
                int id = (MyDG.SelectedItem as Profesores).id;
                var deleteProfe = DbEntityes.Profesores.Where(m => m.id == id).Single();
                DbEntityes.Profesores.Remove(deleteProfe);
                DbEntityes.SaveChanges();
                DbEntityes.Profesores.ToList();
                MyDG.ItemsSource = DbEntityes.Profesores.ToList();
                ControlDatagrid = MyDG;
            } catch
            {
                MessageBox.Show("Se ha producido un error");



            }

        }
    }
}
