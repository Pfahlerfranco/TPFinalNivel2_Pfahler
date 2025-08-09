using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentacion.Formularios
{
    public partial class Inicio : Form
    {
        private const string usuarioValido = "admin";
        private const string passValida = "1234";
        public Inicio()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Inicio_KeyDown;
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContrasena.Text == "1234")
            {
                this.Hide();
                using (var frm = new Stockeatro())
                {
                    frm.ShowDialog(); 
                }
                this.Show(); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void Inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btInicio.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
