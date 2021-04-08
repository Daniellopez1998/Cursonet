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
using System.IO;

namespace LinqWPF
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

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        void cargarGrid()
        {
            var cargarGrid = from p in db.Alumnos select p;
            DataGrid.ItemsSource = cargarGrid;
        }

        //public Boolean Validar(string Caja)
        //{
        //    if (Caja != "")
        //    {
        //        MessageBox.Show("Falta algun campo requerido '*'");
        //    }

        //}

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Alumnos alumno = new Alumnos();
                alumno.Código = txtCodigo.Text;
                alumno.DNI = txtDNI.Text;
                alumno.Nombre = txtNombre.Text;
                alumno.Turno = cmbTurno.Text;
                alumno.Sexo = cmbSexo.Text;
                alumno.Especialidad = cmbEspecialidad.Text;
                alumno.Modulo = cmbModulo.Text;
                alumno.Repetidor = CheckRepe.IsChecked.Value;
                db.Alumnos.InsertOnSubmit(alumno);
                db.SubmitChanges();
                MessageBox.Show("Se ha añadido correctamente");
                cargarGrid();

            }
            catch
            {
                MessageBox.Show("Te falta algun campo obligatorio o el Código esta repetido");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try 
            { 
                Alumnos alumno = db.Alumnos.Single(p => p.Código == txtCodigo.Text);
                alumno.DNI = txtDNI.Text;
                alumno.Nombre = txtNombre.Text;
                alumno.Turno = cmbTurno.Text;
                alumno.Sexo = cmbSexo.Text;
                alumno.Especialidad = cmbEspecialidad.Text;
                alumno.Modulo = cmbModulo.Text;
                alumno.Repetidor = CheckRepe.IsChecked.Value;
                db.SubmitChanges();
                MessageBox.Show("Se ha modificado correctamente");
                cargarGrid();
            }
            catch
            {
                MessageBox.Show("Te falta el campo Código o el Código indicado no existe");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Alumnos alumno = db.Alumnos.Single(p => p.Código == txtCodigo.Text);
                db.Alumnos.DeleteOnSubmit(alumno);
                db.SubmitChanges();
                MessageBox.Show("Se ha eliminado correctamente");
                cargarGrid();
            }
            catch
            {
                MessageBox.Show("Te falta el campo Código o el Código indicado no existe");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (txtBuscarCodigo.Text == "")
            {
                cargarGrid();
            }
            else 
            { 
                var alumno = from p in db.Alumnos where p.Código == txtBuscarCodigo.Text select p;
                DataGrid.ItemsSource = alumno;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (txtBuscarCodigo.Text == "")
            {
                cargarGrid();
            }
            else
            {
                var alumno = from p in db.Alumnos where p.DNI == txtBuscarDNI.Text select p;
                DataGrid.ItemsSource = alumno;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (txtRecuperar.Text == "")
            {
                cargarGrid();
            }
            else { 
            var Recuperar = from p in db.Alumnos where p.Nombre.Contains(txtRecuperar.Text) select p;
            DataGrid.ItemsSource = Recuperar;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var ordenar1 = from p in db.Alumnos orderby p.Nombre ascending select p;
            DataGrid.ItemsSource = ordenar1;

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var ordenar2 = from p in db.Alumnos orderby p.DNI ascending select p;
            DataGrid.ItemsSource = ordenar2;

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var ordenar3 = from p in db.Alumnos orderby p.Turno ascending select p;
            DataGrid.ItemsSource = ordenar3;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var ordenar4 = from p in db.Alumnos orderby p.Código ascending select p;
            DataGrid.ItemsSource = ordenar4;
        }

        private void txtRecuperar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
