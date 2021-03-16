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

namespace ejercicio_filtros_linq
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            fecha1.IsEnabled = true;
            checkbox1.IsEnabled = true;
            fecha2.IsEnabled = true;
            checkbox2.IsEnabled = true;

        }

        private void Unchecked_Checked(object sender, RoutedEventArgs e)
        {
            fecha1.IsEnabled = true;
            checkbox1.IsEnabled = true;
            fecha2.IsEnabled = true;
            checkbox2.IsEnabled = true;

        }


        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            fecha3.IsEnabled = true;

        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            fecha3.IsEnabled = false;

        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            fecha4.IsEnabled = true;

        }
        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            fecha4.IsEnabled = false;

        }

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox1.IsEnabled = true;
        }
        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox1.IsEnabled = false;
        }
    }
}
