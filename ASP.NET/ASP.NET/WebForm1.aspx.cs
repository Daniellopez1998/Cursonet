using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                int resultado;

                resultado = int.Parse(TextBox1.Text) + int.Parse(TextBox2.Text);
                Label3.Text = "La suma de  los dos valores es:" + resultado;
            }
            else
            {
                int resultado;
                resultado = int.Parse(TextBox1.Text) - int.Parse(TextBox2.Text);
                Label3.Text = "La resta de  los dos valores es:" + resultado;
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (DropDownList1.Items[0].Selected) { int suma = int.Parse(TextBox3.Text) + int.Parse(TextBox4.Text); Label6.Text = "La suma es:" + suma + "<br>"; }
            else if (DropDownList1.Items[1].Selected) { int resta = int.Parse(TextBox3.Text) - int.Parse(TextBox4.Text); Label6.Text = "La resta es:" + resta + "<br>"; }
            else if (DropDownList1.Items[2].Selected) { int producto = int.Parse(TextBox3.Text) * int.Parse(TextBox4.Text); Label6.Text = "El producto es:" + producto + "<br>"; }
            else if (DropDownList1.Items[3].Selected) { int division = int.Parse(TextBox3.Text) / int.Parse(TextBox4.Text); Label6.Text = "La division es:" + division + "<br>"; }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            if (ListBox1.Items[0].Selected) { int suma = int.Parse(TextBox5.Text) + int.Parse(TextBox6.Text); Label9.Text = "Lasumaes:" + suma + "<br>"; }
            else if (ListBox1.Items[1].Selected) { int resta = int.Parse(TextBox5.Text) - int.Parse(TextBox6.Text); Label9.Text = "La resta es:" + resta + "<br>"; }
            else if (ListBox1.Items[2].Selected) { int producto = int.Parse(TextBox5.Text) * int.Parse(TextBox6.Text); Label9.Text = "El producto es:" + producto + "<br>"; }
            else if (ListBox1.Items[3].Selected) { int division = int.Parse(TextBox5.Text) / int.Parse(TextBox6.Text); Label9.Text = "La division es:" + division + "<br>"; }
        }
    }
}