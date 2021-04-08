using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinqReal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext northwind = new DataClasses1DataContext();


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'linqRealDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.linqRealDataSet.Products);
            cargarCombo();
            cargarGrid();
        }
        
        void cargarCombo()
        {
            var cargarCombo = from p in northwind.Products select p.ProductName;
            cmbEliminar.DataSource = cargarCombo;
        }

        void cargarGrid()
        {
            var cargarGrid = from p in northwind.Products select p;
            GridDatos.DataSource = cargarGrid;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = txtProd.Text;
            MyProduct.UnitPrice = int.Parse(txtPrec.Text);
            MyProduct.UnitsInStock = short.Parse(txtStock.Text);
            MyProduct.CategoryID = int.Parse(txtCat.Text);
            northwind.Products.InsertOnSubmit(MyProduct);
            northwind.SubmitChanges();
            cargarCombo();
            cargarGrid();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(cmbEliminar.SelectedItem.ToString());
            Products MyProducto = northwind.Products.Single(p => p.ProductName == cmbEliminar.SelectedItem.ToString());
            MyProducto.ProductName = cmbEliminar.SelectedItem.ToString();
            MyProducto.UnitPrice = int.Parse(txtPrec.Text);
            MyProducto.UnitsInStock = short.Parse(txtStock.Text);
            MyProducto.CategoryID = int.Parse(txtCat.Text);
            northwind.SubmitChanges();
            cargarCombo();
            cargarGrid();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Products MyProduct = northwind.Products.Single(p => p.ProductName == cmbEliminar.SelectedItem.ToString());
            northwind.Products.DeleteOnSubmit(MyProduct);
            northwind.SubmitChanges();
            cargarCombo();
            cargarGrid();
        }

        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
