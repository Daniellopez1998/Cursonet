using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPMacroEjercicioJueves
{
    public partial class GestionClientes : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                try { 
                    string s = System.Configuration.ConfigurationManager.ConnectionStrings["ASPMacroEjercicioJuevesConnectionString1"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(s);
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("insert into cliente(id,nombre,apellido1,apellido2,ciudad,categoría) values(" + this.TxtIdA.Text + ",'" +
                        TxtNombreA.Text + "','" + TxtApellido1A.Text + "','" + TxtApellido2A.Text + "','" + TxtCiudadA.Text + "'," + TxtCategoriaA.Text + ")", conexion);
                    comando.ExecuteNonQuery();
                    Label14.Text = "Se registro el usuario";
                    conexion.Close();
                }
                catch
                {
                    Response.Write("<script>alert('El Id esta repetido');</script>");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ASPMacroEjercicioJuevesConnectionString1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando2 = new SqlCommand("select id,nombre,apellido1,apellido2,ciudad,categoría from cliente " + " where id=" +
                this.ddlIdB.Text, conexion);
            SqlDataReader registro = comando2.ExecuteReader();
            if (registro.Read()) 
            { 
                this.TxtNombreM.Text = registro["nombre"].ToString();
                this.TxtApellido1M.Text = registro["apellido1"].ToString();
                this.TxtApellido2M.Text = registro["apellido2"].ToString();
                this.TxtCiudadM.Text = registro["ciudad"].ToString();
                this.TxtCategoriaM.Text = registro["categoría"].ToString();
            }
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ASPMacroEjercicioJuevesConnectionString1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando3 = new SqlCommand("update cliente set " + "nombre='" + this.TxtNombreM.Text + "',apellido1='" + this.TxtApellido1M.Text + "',apellido2='" + this.TxtApellido2M.Text + "',ciudad='" + this.TxtCiudadM.Text + "',categoria='" + this.TxtCategoriaM.Text + "' where id=" +
                this.ddlIdM.Text, conexion);
            int cantidad = comando3.ExecuteNonQuery();
            if (cantidad == 1)
                this.Label15.Text = "Datos modificados";
            conexion.Close();
        }
    }
}