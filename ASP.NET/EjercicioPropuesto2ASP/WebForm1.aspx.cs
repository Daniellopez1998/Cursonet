using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto2ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Items[0].Selected && RadioButtonList2.Items[0].Selected && RadioButtonList3.Items[0].Selected && RadioButtonList4.Items[0].Selected) 
            {
                Label5.Text = "Tienes 0 aciertos";
            }
            else if (RadioButtonList1.Items[1].Selected && RadioButtonList2.Items[0].Selected && RadioButtonList3.Items[0].Selected && RadioButtonList4.Items[0].Selected)
            {
                Label5.Text = "Tienes 0 aciertos";
            }
            else if (RadioButtonList1.Items[2].Selected && RadioButtonList2.Items[0].Selected && RadioButtonList3.Items[0].Selected && RadioButtonList4.Items[0].Selected)
            {
                Label5.Text = "Tienes 1 acierto";
            }
            else if (RadioButtonList1.Items[0].Selected && RadioButtonList2.Items[1].Selected && RadioButtonList3.Items[0].Selected && RadioButtonList4.Items[0].Selected)
            {
                Label5.Text = "Tienes 1 acierto";
            }
            else if (RadioButtonList1.Items[0].Selected && RadioButtonList2.Items[2].Selected && RadioButtonList3.Items[0].Selected && RadioButtonList4.Items[0].Selected)
            {
                Label5.Text = "Tienes 0 aciertos";
            }
        }


    }
}