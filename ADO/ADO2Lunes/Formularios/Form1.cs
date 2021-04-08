using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

//Using especial para ADO
using System.Data.SqlClient;

namespace ADO2Lunes
{
    public partial class Form1 : Form
    {

        //La conexion con Sql
        private SqlConnection conexion = new SqlConnection("Data Source=CADAVILES04\\SQLEXPRESS;Initial Catalog=ADO;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
            Cargar();
        }

        //*********************************************Cargar controles*********************************************
        private void Cargar()
        {
           //datatable es una tabla virtual
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Cliente";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void CargarCombo()
        {
           //dataset es un conjunto de datos
            DataSet ds = new DataSet();
            string cadena = "SELECT * FROM Cliente";
            SqlDataAdapter da = new SqlDataAdapter(cadena, conexion);
            da.Fill(ds, "Cliente");
            comboBox1.DataSource = ds.Tables[0].DefaultView;
            comboBox1.ValueMember = "IdCliente";
        }




        //*********************************************Grueso*********************************************
        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir conexion y hacer las variables
            conexion.Open();
            string IdCliente = textBox2.Text;
            string Nombre = textBox3.Text;
            string Apellidos = textBox4.Text;
        
            //El bombo
            string cadena = "Insert into Cliente(IdCliente,Apellidos,Nombre)  values (" + IdCliente + ",'" + Apellidos + "','" + Nombre + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
            }
            catch
            {
                MessageBox.Show("Mete valores para que funcione");
            }
            //Vaciar los contenedores
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            //Cargar los controles
            Cargar();
            CargarCombo();
            //Cerrar la conexion
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string IdCliente = textBox2.Text;
            string Nombre = textBox3.Text;
            string Apellidos = textBox4.Text;
            string cadena = "update Cliente set Nombre='" + Nombre + "', Apellidos='" + Apellidos + "' Where IdCliente=" + IdCliente;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            try {
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del artículo");
                }
                else
                {
                    MessageBox.Show("No exite un artículo con el código ingresado");
                }
            }
            catch
            {
                MessageBox.Show("Tienes que indicar un IdCliente para modificarlo");
            }

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Cargar();
            CargarCombo();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string IdCliente = textBox2.Text;
            string cadena = "delete from Cliente where IdCliente=" + IdCliente;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            try 
            {
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se han borrado los datos del cliente");
                    
                }
                else
                {
                    MessageBox.Show("No exite un artículo con el código ingresado");
                }
            }

            catch
            {
                MessageBox.Show("Tienes que indicar un IdCliente para eliminarlo");
            }
      
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Cargar();
            CargarCombo();
            conexion.Close();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aDODataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.aDODataSet1.Cliente);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
                conexion.Open();
                string id = comboBox1.Text;
                string cadena = "select IdCliente, Nombre, Apellidos from Cliente where IdCliente=" + id;

                //Definimos un Sqlcommand para atacar la base de datos (cadena Sql + Conexion)
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //Creamos un Objeto Reader para leer 
                try { 
                SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {
                        textBox1.Text = registro["Nombre"].ToString() + " " + registro["Apellidos"].ToString(); 
                    }
                    else
                    {
                        MessageBox.Show("No existe el IdCliente");
                        textBox1.Text = "";
                    }
                }
                catch
                {
                  
                }
            }
            catch
            {

            }
            conexion.Close();
            
        }
    }
}
