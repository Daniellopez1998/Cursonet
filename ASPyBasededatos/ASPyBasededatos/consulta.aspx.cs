using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPyBasededatos
{
    public partial class consulta : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select Nombre,Clave,Mail from Usuarios " + " where nombre='" +
                this.TextBox1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                this.Label4.Text = "Clave:" + registro["clave"] + "<br>" + "Mail:" + registro["mail"];
            else
                this.Label4.Text = "No existe un usuario con dicho nombre";
            conexion.Close();
        }
    }
}