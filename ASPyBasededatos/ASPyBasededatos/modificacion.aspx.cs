using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPyBasededatos
{
    public partial class modificacion : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando =new SqlCommand("select Nombre,Clave,Mail from Usuarios where Nombre='" + this.TextBox1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.TextBox2.Text = registro["clave"].ToString();
                this.TextBox3.Text = registro["mail"].ToString();
                this.Label1.Text = "Usuario encontrado";
            }
            else
                this.Label1.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update Usuarios set " + "Clave='" + this.TextBox2.Text + "',Mail='" + this.TextBox3.Text + "' where Nombre='" +
                this.TextBox1.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
                this.Label5.Text = "Datos modificados";
            else
                this.Label5.Text = "No existe el usuario";
            conexion.Close();
        }
    }
}