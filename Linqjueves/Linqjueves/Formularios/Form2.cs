using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linqjueves
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login, Password;
            Login = txtUsuario.Text.Trim();
            Password = txtContraseña.Text.TrimEnd();
            if ((Login == "Daniel" || Login == "Ainhoa") && Password == "Zona2")
            {

                MDIParent1 frm = new MDIParent1();
                frm.FormClosing += new FormClosingEventHandler(FormPrincipal_FormClosing);

                this.Hide();

                frm.Show();

            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }

        private void FormPrincipal_FormClosing(Object sender, FormClosingEventArgs e)
        {
           Application.Exit(); 
        }
    }
}
