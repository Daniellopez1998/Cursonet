using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        DataSetDataContext ClienteLinq = new DataSetDataContext();
        public Form1()
        {
            InitializeComponent();
            this.ListarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(txtNombre.Text.ToUpper(), txtApellido.Text.ToUpper(), txtApellido2.Text.ToUpper(), txtTelefono.Text.ToUpper());
            this.ListarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.ModificarCliente(txtNombre.Text.ToUpper(), txtApellido.Text.ToUpper(), txtApellido2.Text.ToUpper(), txtTelefono.Text.ToUpper());
            this.ListarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            ClienteLinq.EliminarCliente(txtNombre.Text);
            this.ListarClientes();
        }
        
        void ListarClientes()
        {
            GridDatos.DataSource = ClienteLinq.ListarCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtApellido2.Clear();
            txtTelefono.Clear();
        }
    }
}
