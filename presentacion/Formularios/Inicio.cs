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
        public Inicio()
        {
            InitializeComponent();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            Stockeatro frm = new Stockeatro();
            frm.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
