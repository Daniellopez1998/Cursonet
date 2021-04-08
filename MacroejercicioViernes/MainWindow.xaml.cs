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

namespace MacroejercicioViernes
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

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
             //VALIDACION QUE SE HA RELLENADO MEDIANTE IF ELSE
            if (!IsValid(dtmFecha.Text))
            {
                MessageBox.Show("FALTA ELEMENTO FECHA");
                labelCorrector1.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtDescripcion.Text))
            {
                MessageBox.Show("FALTA ELEMENTO DESCRIPCION");
                labelCorrector2.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtNombre.Text))
            {
                MessageBox.Show("FALTA ELEMENTO NOMBRE");
                labelCorrector3.Visibility = Visibility.Visible;
            }

            else if (!IsValid(Descuento.Text))
            {
                MessageBox.Show("FALTA ELEMENTO DESCUENTO");
                labelCorrector4.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtVenta.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtVenta.Text, "[^0-9]"))
            {
                MessageBox.Show("FALTA ELEMENTO CANTIDAD O SU VALOR NO ES NUMERICO");
                labelCorrector6.Visibility = Visibility.Visible;
               
            }

            else if (!IsValid(PrecUni.Text) || System.Text.RegularExpressions.Regex.IsMatch(PrecUni.Text, "[^0-9]"))
            {
                MessageBox.Show("FALTA ELEMENTO PRECIO/UNI");
                labelCorrector7.Visibility = Visibility.Visible;
               
            }

            else if (!IsValid(txtPagado.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtPagado.Text, "[^0-9]"))
            {
                MessageBox.Show("FALTA ELEMENTO PAGADO");
                labelCorrector8.Visibility = Visibility.Visible;
               
            }
            else 
            { 
                lvDatos.Items.Add(new{Nombre = txtNombre.Text, Venta = txtVenta.Text, PrecUni = PrecUni.Text, Descuento = Descuento.Text});
                int cont;
                cont=int.Parse(txtRegistros.Text);
                cont = cont + 1;
                txtRegistros.Text = cont.ToString();
            }
        }
        public Boolean IsValid(string Caja)
        {
            if (Caja != "") return true;
            else return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (!IsValid(dtmFecha.Text))
            {
                MessageBox.Show("FALTA ELEMENTO FECHA");
                labelCorrector1.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtDescripcion.Text))
            {
                MessageBox.Show("FALTA ELEMENTO DESCRIPCION");
                labelCorrector2.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtNombre.Text))
            {
                MessageBox.Show("FALTA ELEMENTO NOMBRE");
                labelCorrector3.Visibility = Visibility.Visible;
            }

            else if (!IsValid(Descuento.Text))
            {
                MessageBox.Show("FALTA ELEMENTO DESCUENTO");
                labelCorrector4.Visibility = Visibility.Visible;
            }

            else if (!IsValid(txtVenta.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtVenta.Text, "[^0-9]"))
            {
                MessageBox.Show("FALTA ELEMENTO CANTIDAD O SU VALOR NO ES NUMERICO");
                labelCorrector6.Visibility = Visibility.Visible;

            }

            else if (!IsValid(PrecUni.Text) || System.Text.RegularExpressions.Regex.IsMatch(PrecUni.Text, "[^0-9]"))
            {
                MessageBox.Show("FALTA ELEMENTO PRECIO/UNI");
                labelCorrector7.Visibility = Visibility.Visible;

            }

            else if (!IsValid(txtPagado.Text) || System.Text.RegularExpressions.Regex.IsMatch(txtPagado.Text, "[^0-9]"))
            {
                MessageBox.Show("FALTA ELEMENTO PAGADO");
                labelCorrector8.Visibility = Visibility.Visible;

            }
            else 
            {
                int Cantidad = int.Parse(txtVenta.Text);
                int PrecioUni = int.Parse(PrecUni.Text);
                int intPagado = int.Parse(txtPagado.Text);
                int intDescuento = int.Parse(Descuento.Text);
                int total;
                int Sindes;
                Sindes = (Cantidad * PrecioUni) + (Cantidad * PrecioUni * 21 / 100);
                total = intPagado-(Sindes - (Sindes * intDescuento/100));
                txtTotal.Text = total.ToString();
            }
            
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtVenta.Clear();
            PrecUni.Clear();
            txtPagado.Clear();
            txtTotal.Clear();
            labelCorrector1.Visibility = Visibility.Hidden;
            labelCorrector2.Visibility = Visibility.Hidden;
            labelCorrector3.Visibility = Visibility.Hidden;
            labelCorrector4.Visibility = Visibility.Hidden;
            labelCorrector6.Visibility = Visibility.Hidden;
            labelCorrector7.Visibility = Visibility.Hidden;
            labelCorrector8.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try { 
            lvDatos.Items.RemoveAt(lvDatos.SelectedIndex); 
            lvDatos.Items.Refresh();
                int cont;
                cont = int.Parse(txtRegistros.Text);
                cont = cont -1;
                txtRegistros.Text = cont.ToString();
            }
            catch
            {
                MessageBox.Show("SELECCIONA UNA FILA PARA BORRARLA");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lvDatos.Items.Clear();
            txtRegistros.Text = "0";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PrintDialog pDialog = new PrintDialog(); 
            pDialog.ShowDialog();
        }

        private void txtRegistros_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
