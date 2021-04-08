using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPyBasededatos
{
    public partial class alta : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Usuarios(Nombre,Clave,Mail) values('" + this.TextBox1.Text + "','" +
                TextBox2.Text + "','" + TextBox3.Text + "')", conexion);
            comando.ExecuteNonQuery();
            Label4.Text = "Se registro el usuario";
            conexion.Close();
        }
    }
}