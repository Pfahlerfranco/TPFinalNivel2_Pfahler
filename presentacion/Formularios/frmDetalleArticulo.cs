using System;
using System.IO;
using System.Windows.Forms;
using dominio;

namespace presentacion.Formularios
{
    public partial class frmDetalleArticulo : Form
    {
        private readonly Articulo articulo;

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo ?? throw new ArgumentNullException(nameof(articulo));
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            txtNombre.Text = articulo.Nombre;
            txtCodigo.Text = articulo.Codigo;
            txtDescripcion.Text = articulo.Descripcion;
            txtMarca.Text = articulo.Marca?.Descripcion ?? "";
            txtCategoria.Text = articulo.Categoria?.Descripcion ?? "";
            txtPrecio.Text = articulo.Precio.ToString("C");

            CargarImagen(articulo.ImagenUrl);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imagen))
                    throw new Exception("sin imagen");

                string ruta = imagen;
                if (!imagen.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    // Soporta ruta relativa guardada en BD (ej: "images\foto.jpg")
                    ruta = Path.IsPathRooted(imagen) ? imagen : Path.Combine(Application.StartupPath, imagen);
                }

                pbImagen.Load(ruta);
            }
            catch
            {
                pbImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
