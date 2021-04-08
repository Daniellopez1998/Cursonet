using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=CADAVILES04\\SQLEXPRESS;Initial Catalog=ADO;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string ID = textBox1.Text;
            string Nombre = textBox2.Text;
            string Edad = textBox3.Text;
            string cadena="Insert into PruebaADO(ID,Nombre,Edad) "+"values ("+ID+",'"+Nombre+"',"+Edad+")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string ID = textBox4.Text;
            string cadena = "select ID,Nombre,Edad from PruebaADO where ID=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label4.Text = registro["Nombre"].ToString();
                label5.Text = registro["Edad"].ToString();
                button3.Enabled = true;
            }
            
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string ID = textBox4.Text;
            string cadena = "delete from PruebaADO where ID=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                label4.Text = "";
                label5.Text = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
            {
                MessageBox.Show("No Existe un artículo con el código ingresado");
                
                button3.Enabled = false;
            }
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string ID = textBox5.Text;
            string Nombre = textBox6.Text;
            string Edad = textBox7.Text;
            string cadena = "update PruebaADO set Nombre='" + Nombre + "', Edad=" + Edad + " Where ID=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            else
            {
                MessageBox.Show("No exite un artículo con el código ingresado");
                conexion.Close();
                button5.Enabled = false;
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = textBox5.Text;
            string cadena = "select ID,Nombre,Edad from PruebaADO where ID=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox6.Text = registro["Nombre"].ToString();
                textBox7.Text = registro["Edad"].ToString();
                button5.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
                
            }
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aDODataSet1.PruebaADO' Puede moverla o quitarla según sea necesario.
            this.pruebaADOTableAdapter1.Fill(this.aDODataSet1.PruebaADO);

        }
    }
}
