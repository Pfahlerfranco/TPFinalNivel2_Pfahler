using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion.Formularios
{
    public partial class frmayuda : Form
    {
        public frmayuda()
        {
            InitializeComponent();
            lbAyuda.Text = "Esta es la pantalla de ayuda.\n\n" +
                          "Usuario: admin\n" +
                          "Contraseña: 1234\n" +
                          "Para más información consulte al soporte técnico.\n" +
                          "0800-05454-8548\n" +
                          "o Mail\n" +
                          "SoporteTecnico@Stokeator.com";
        }

        private void frmayuda_Load(object sender, EventArgs e)
        {

        }
    }
}
