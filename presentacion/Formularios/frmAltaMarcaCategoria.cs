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
    public partial class frmAltaMarcaCategoria : Form
    {
        public frmAltaMarcaCategoria()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get => this.Text;
            set => this.Text = value;
        }

        public string Etiqueta
        {
            get => lblTexto.Text;
            set => lblTexto.Text = value;
        }

        public string Valor => txtValor.Text.Trim();

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, ingresá un texto.");
                txtValor.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}