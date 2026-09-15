using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && 
            u.Clave == txtclave.Text).FirstOrDefault();

            
            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
             

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text="";
            txtclave.Text = "";

            this.Show();
        }
    }
}
