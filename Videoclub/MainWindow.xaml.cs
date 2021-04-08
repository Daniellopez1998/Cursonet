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

namespace Videoclub
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

        public Boolean IsValid(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!IsValid(txtCodigo.Text))
            {
                MessageBox.Show("FALTA ELEMENTO CODIGO");
                labelCorrector1.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtPrecio.Text))
            {
                MessageBox.Show("FALTA ELEMENTO PRECIO");
                labelCorrector2.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtDescripcion.Text))
            {
                MessageBox.Show("FALTA ELEMENTO DESCRIPCION");
                labelCorrector3.Visibility = Visibility.Visible;
            }

            else if (radCompac.IsChecked == false && radLibro.IsChecked == false)
            {
                MessageBox.Show("FALTA ELEMENTO COMPACTDISK/LIBRO");
                labelCorrector4.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}