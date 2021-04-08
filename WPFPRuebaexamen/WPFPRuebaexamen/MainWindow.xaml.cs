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

namespace WPFPRuebaexamen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool Borrado = false;
        Model1Container db = new Model1Container();
        public static DataGrid ControlDatagrid;
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = db.LibrosSet.ToList();
            ControlDatagrid = DataGrid;
        }

        public void cargaGrid()
        {
            DataGrid.ItemsSource = db.LibrosSet.ToList();
            ControlDatagrid = DataGrid;
        }

        private void Añadir_Click(object sender, RoutedEventArgs e)
        {
            Libros Libro = new Libros();
            
            Libro.Titulo = txtTitulo.Text;
            Libro.Autor = txtAutor.Text;
            Libro.Editorial = txtEditorial.Text;
            db.LibrosSet.Add(Libro);
            db.SaveChanges();
            cargaGrid();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            int id = (DataGrid.SelectedItem as Libros).Id;
            var deleteLibro = db.LibrosSet.Where(m => m.Id == id).Single();
            db.LibrosSet.Remove(deleteLibro);
            db.SaveChanges();
            Borrado = true;
            cargaGrid();
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            int id = (DataGrid.SelectedItem as Libros).Id;
            var updateLibro = db.LibrosSet.Where(m => m.Id == id).Single();
            txtId.Text = id.ToString();
            updateLibro.Titulo = txtTitulo.Text;
            updateLibro.Autor = txtAutor.Text;
            updateLibro.Editorial = txtEditorial.Text; 
            db.SaveChanges();
            cargaGrid();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Borrado)
            {
                DataGrid.SelectedIndex = -1;
                Borrado = false;
            }
            else
            {
                int id = (DataGrid.SelectedItem as Libros).Id;
                var updateLibro = db.LibrosSet.Where(m => m.Id == id).Single();
                txtId.Text = id.ToString();
                txtTitulo.Text = updateLibro.Titulo;
                txtAutor.Text = updateLibro.Autor;
                txtEditorial.Text = updateLibro.Editorial;
            }
            
        }
    }
}
